
namespace LopushokDemo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.CostChangeBtn = new System.Windows.Forms.Button();
            this.DownCheck = new System.Windows.Forms.CheckBox();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.FiltrCombo = new System.Windows.Forms.ComboBox();
            this.SortCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionPersonCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionWorkshopNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minCostForAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.titleDataGridViewTextBoxColumn,
            this.productTypeIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.articleNumberDataGridViewTextBoxColumn,
            this.productionPersonCountDataGridViewTextBoxColumn,
            this.productionWorkshopNumberDataGridViewTextBoxColumn,
            this.minCostForAgentDataGridViewTextBoxColumn});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(5, 54);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(851, 359);
            this.productDataGridView.TabIndex = 25;
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(338, 419);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(152, 23);
            this.deleteProduct.TabIndex = 22;
            this.deleteProduct.Text = "Удалить товар";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Location = new System.Drawing.Point(171, 419);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(152, 23);
            this.EditProductBtn.TabIndex = 23;
            this.EditProductBtn.Text = "Редактировать товар";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(4, 419);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(152, 23);
            this.AddProductBtn.TabIndex = 24;
            this.AddProductBtn.Text = "Добавить товар";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // CostChangeBtn
            // 
            this.CostChangeBtn.Location = new System.Drawing.Point(540, 419);
            this.CostChangeBtn.Name = "CostChangeBtn";
            this.CostChangeBtn.Size = new System.Drawing.Size(152, 23);
            this.CostChangeBtn.TabIndex = 21;
            this.CostChangeBtn.Text = "Изменить стоимость на ...";
            this.CostChangeBtn.UseVisualStyleBackColor = true;
            // 
            // DownCheck
            // 
            this.DownCheck.AutoSize = true;
            this.DownCheck.Location = new System.Drawing.Point(155, 25);
            this.DownCheck.Name = "DownCheck";
            this.DownCheck.Size = new System.Drawing.Size(75, 17);
            this.DownCheck.TabIndex = 20;
            this.DownCheck.Text = "убывание";
            this.DownCheck.UseVisualStyleBackColor = true;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(255, 22);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(139, 20);
            this.SearchTxt.TabIndex = 19;
            // 
            // FiltrCombo
            // 
            this.FiltrCombo.FormattingEnabled = true;
            this.FiltrCombo.Items.AddRange(new object[] {
            "Все типы"});
            this.FiltrCombo.Location = new System.Drawing.Point(442, 22);
            this.FiltrCombo.Name = "FiltrCombo";
            this.FiltrCombo.Size = new System.Drawing.Size(157, 21);
            this.FiltrCombo.TabIndex = 17;
            // 
            // SortCombo
            // 
            this.SortCombo.FormattingEnabled = true;
            this.SortCombo.Items.AddRange(new object[] {
            "Без сортировки",
            "Наименование",
            "Номер цеха",
            "Мин.стоимость"});
            this.SortCombo.Location = new System.Drawing.Point(9, 22);
            this.SortCombo.Name = "SortCombo";
            this.SortCombo.Size = new System.Drawing.Size(138, 21);
            this.SortCombo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Поиск";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Сортировка";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 82;
            // 
            // productTypeIDDataGridViewTextBoxColumn
            // 
            this.productTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ProductTypeID";
            this.productTypeIDDataGridViewTextBoxColumn.HeaderText = "Тип продукции";
            this.productTypeIDDataGridViewTextBoxColumn.Name = "productTypeIDDataGridViewTextBoxColumn";
            this.productTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 82;
            // 
            // articleNumberDataGridViewTextBoxColumn
            // 
            this.articleNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.articleNumberDataGridViewTextBoxColumn.DataPropertyName = "ArticleNumber";
            this.articleNumberDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.articleNumberDataGridViewTextBoxColumn.Name = "articleNumberDataGridViewTextBoxColumn";
            this.articleNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.articleNumberDataGridViewTextBoxColumn.Width = 73;
            // 
            // productionPersonCountDataGridViewTextBoxColumn
            // 
            this.productionPersonCountDataGridViewTextBoxColumn.DataPropertyName = "ProductionPersonCount";
            this.productionPersonCountDataGridViewTextBoxColumn.HeaderText = "Кол-во работников";
            this.productionPersonCountDataGridViewTextBoxColumn.Name = "productionPersonCountDataGridViewTextBoxColumn";
            this.productionPersonCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionWorkshopNumberDataGridViewTextBoxColumn
            // 
            this.productionWorkshopNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductionWorkshopNumber";
            this.productionWorkshopNumberDataGridViewTextBoxColumn.HeaderText = "Номер цеха";
            this.productionWorkshopNumberDataGridViewTextBoxColumn.Name = "productionWorkshopNumberDataGridViewTextBoxColumn";
            this.productionWorkshopNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minCostForAgentDataGridViewTextBoxColumn
            // 
            this.minCostForAgentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.minCostForAgentDataGridViewTextBoxColumn.DataPropertyName = "MinCostForAgent";
            this.minCostForAgentDataGridViewTextBoxColumn.HeaderText = "Мин. стоимость";
            this.minCostForAgentDataGridViewTextBoxColumn.Name = "minCostForAgentDataGridViewTextBoxColumn";
            this.minCostForAgentDataGridViewTextBoxColumn.ReadOnly = true;
            this.minCostForAgentDataGridViewTextBoxColumn.Width = 104;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LopushokDemo.Product);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.CostChangeBtn);
            this.Controls.Add(this.DownCheck);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.FiltrCombo);
            this.Controls.Add(this.SortCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button CostChangeBtn;
        private System.Windows.Forms.CheckBox DownCheck;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox FiltrCombo;
        private System.Windows.Forms.ComboBox SortCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionPersonCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionWorkshopNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minCostForAgentDataGridViewTextBoxColumn;
    }
}

