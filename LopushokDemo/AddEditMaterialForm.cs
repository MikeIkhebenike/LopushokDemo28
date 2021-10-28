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
    public partial class AddEditMaterialForm : Form
    {
        public ProductMaterial prd_mat { get; set; } = null;

        public int ID { get; set; }

        public AddEditMaterialForm()
        {
            InitializeComponent();
        }

        private void AddEditMaterialForm_Load(object sender, EventArgs e)
        {
            materialBindingSource.DataSource = Program.db.Material.ToList();

            if (prd_mat != null)
            {
                productMaterialBindingSource.Add(prd_mat);
                Text = "Изменение данных о материалах продукции";
            }
            else
            {
                ProductMaterial prdmat = new ProductMaterial();
                prdmat.ProductID = ID;
                prdmat.Count = 0;
                productMaterialBindingSource.Add(prdmat);
                Text = "Добавление данных о материалах продукции";
            }
        }
    }
}
