using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopushokDemo
{
    public partial class Form1 : Form
    {
        // коллекция выбранных в DataGridView товаров
        static public List<Product> lstSelectedProduct = new List<Product>();
        // коллекция показываемых товаров
        List<Product> lstProduct = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // устанавливаем тип сортировки - "Без"
            SortCombo.SelectedIndex = 0;
            // загружаем список названий типов товаров
            List<string> lstTypes = Program.db.ProductType.Select(a => a.Title).ToList();
            lstTypes.Insert(0, "Все типы");
            // передаем данные фильтру
            FiltrCombo.DataSource = lstTypes;

            // подготавливаем данные для показа
            DataWork();
        }
        /////////////////////////////////////////////////
        // параметры показа продукции 
        string filtr = "Все типы"; // фильтр показа продукции;
        string sort = "Наименование"; // сортировки продукции
        string search = "";  // поиск по наименованию и описанию

        /////////////////////////////////////////////////
        //  Подготовка данных для показа 
        public void DataWork()
        {
            // вначале выбираем все товары
            lstProduct = Program.db.Product.ToList();

            /////////////////////////////////////////////            
            // фильтрация по типам товаров
            if (filtr != "Все типы")
            {
                // отбираем только по заданному производителю
                lstProduct = lstProduct.Where(p => (p.ProductType.Title == filtr)).ToList();
            }
            /////////////////////////////////////////////
            // поиск по заданной строке
            if (search != "")
            {   // отбираем товары с заданной строкой в названии
                search = search.ToUpper();
                // поиск с учетом регистра
                // ToUpper() для пустой строки не срабатывает
                lstProduct = lstProduct
                    .Where(p => (p.Title.ToUpper().Contains(search)) ||
                        (p.Description != null && // есть описание ?
                         p.Description.ToUpper().Contains(search)))
                    .ToList();
            }
            /////////////////////////////////////////////
            // сортировка по разным полям
            if (sort != "Без сортировки")
            {
                if (sort == "Наименование")
                {   // сортируем отобранные товары по наименованию
                    if (!DownCheck.Checked)
                        lstProduct = lstProduct.OrderBy(p => p.Title).ToList();
                    else
                        lstProduct = lstProduct.
                            OrderByDescending(p => p.Title).ToList();
                }
                if (sort == "Номер цеха")
                {
                    if (sort == "Номер цеха")
                    {   // сортируем отобранные товары по наименованию
                        if (!DownCheck.Checked)
                            lstProduct = lstProduct.OrderBy(p => p.ProductionWorkshopNumber).ToList();
                        else
                            lstProduct = lstProduct.
                                OrderByDescending(p => p.ProductionWorkshopNumber).ToList();
                    }
                    if (sort == "Мин.стоимость")
                    {   // сортируем отобранные товары по наименованию
                        if (!DownCheck.Checked)
                            lstProduct = lstProduct.OrderBy(p => p.MinCostForAgent).ToList();
                        else
                            lstProduct = lstProduct.
                                OrderByDescending(p => p.MinCostForAgent).ToList();
                    }
                }
            }
            /////////////////////////////////////////
            // передаем промежуточному элементу
            productBindingSource.DataSource = lstProduct;
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddEditMaterialForm form = new AddEditMaterialForm();
            form.prd = null;
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DataWork();
            }
        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            AddEditMaterialForm form = new AddEditMaterialForm();
            Product prd = (Product)productBindingSource.Current;
            form.prd = prd;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DataWork();
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            Product prd = (Product)productBindingSource.Current;
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить продукт - " + prd.Title,
               "Удаление продукции", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // Проверяем - можно ли удалять эту продукцию
                // проверяем - есть ли данные о продажах товара?
                //if (prd.ProductSale.Count > 0)
                //{
                //    MessageBox.Show("Данную продукцию удалить нельзя, т.к. есть данные о продажах!");
                //    return;
                //}
                //// проверяем - есть данные о материалах?
                //if (prd.ProductMaterial.Count > 0)
                //{//  удаляем данные о материалах
                //    //foreach (ProductMaterial prd_mtr in prd.ProductMaterial)
                //    //{
                //    //    Program.db.ProductMaterial.Remove(prd_mtr);
                //    //}
                //    Program.db.ProductMaterial.RemoveRange(prd.ProductMaterial);
                //}
                //// проверяем - есть данные о истории стоимости?
                //if (prd.ProductCostHistory.Count > 0)
                //{//  удаляем данные о истории стоимости
                //    //foreach (ProductCostHistory prd_hist in prd.ProductCostHistory)
                //    //{
                //    //    Program.db.ProductCostHistory.Remove(prd_hist);
                //    //}
                //    Program.db.ProductCostHistory.RemoveRange(prd.ProductCostHistory);
                //}

                // удаляем выбранный объект из коллекции
                Program.db.Product.Remove(prd);

                // сохраняем сделанные изменения в БД
                try  // обрабатываем исключения
                {
                    // сохраняем сделанные изменения в БД
                    Program.db.SaveChanges();
                    // завершаем работу формы
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)  // если ошибка, то попадаем сюда
                {
                    // выводим сообщение SQL Server об ошибке
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }
    }
}
