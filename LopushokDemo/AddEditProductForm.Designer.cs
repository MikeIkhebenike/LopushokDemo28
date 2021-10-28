
namespace LopushokDemo
{
    partial class AddEditProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label titleLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteMaterBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.productMaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.articleNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentTextBox = new System.Windows.Forms.TextBox();
            this.productionPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.productTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProdictPictureBox = new System.Windows.Forms.PictureBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            articleNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdictPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteMaterBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.productMaterialDataGridView);
            this.panel1.Location = new System.Drawing.Point(475, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 294);
            this.panel1.TabIndex = 64;
            // 
            // DeleteMaterBtn
            // 
            this.DeleteMaterBtn.Location = new System.Drawing.Point(230, 258);
            this.DeleteMaterBtn.Name = "DeleteMaterBtn";
            this.DeleteMaterBtn.Size = new System.Drawing.Size(96, 23);
            this.DeleteMaterBtn.TabIndex = 1;
            this.DeleteMaterBtn.Text = "Удалить";
            this.DeleteMaterBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(120, 258);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(96, 23);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(7, 258);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(96, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // productMaterialDataGridView
            // 
            this.productMaterialDataGridView.AllowUserToAddRows = false;
            this.productMaterialDataGridView.AllowUserToDeleteRows = false;
            this.productMaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productMaterialDataGridView.Location = new System.Drawing.Point(3, 8);
            this.productMaterialDataGridView.Name = "productMaterialDataGridView";
            this.productMaterialDataGridView.ReadOnly = true;
            this.productMaterialDataGridView.Size = new System.Drawing.Size(329, 234);
            this.productMaterialDataGridView.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(305, 326);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(108, 23);
            this.DeleteBtn.TabIndex = 63;
            this.DeleteBtn.Text = "Удалить ";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.Location = new System.Drawing.Point(6, 96);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(79, 13);
            articleNumberLabel.TabIndex = 44;
            articleNumberLabel.Text = "Article Number:";
            // 
            // articleNumberTextBox
            // 
            this.articleNumberTextBox.Location = new System.Drawing.Point(165, 93);
            this.articleNumberTextBox.Name = "articleNumberTextBox";
            this.articleNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.articleNumberTextBox.TabIndex = 46;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 122);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 47;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(86, 119);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 51);
            this.descriptionTextBox.TabIndex = 48;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(6, 42);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 49;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(165, 39);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(121, 20);
            this.iDTextBox.TabIndex = 50;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(6, 179);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(39, 13);
            imageLabel.TabIndex = 51;
            imageLabel.Text = "Image:";
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(165, 176);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(121, 20);
            this.imageTextBox.TabIndex = 52;
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Location = new System.Drawing.Point(6, 205);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(100, 13);
            minCostForAgentLabel.TabIndex = 53;
            minCostForAgentLabel.Text = "Min Cost For Agent:";
            // 
            // minCostForAgentTextBox
            // 
            this.minCostForAgentTextBox.Location = new System.Drawing.Point(165, 202);
            this.minCostForAgentTextBox.Name = "minCostForAgentTextBox";
            this.minCostForAgentTextBox.Size = new System.Drawing.Size(121, 20);
            this.minCostForAgentTextBox.TabIndex = 54;
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Location = new System.Drawing.Point(6, 231);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(128, 13);
            productionPersonCountLabel.TabIndex = 55;
            productionPersonCountLabel.Text = "Production Person Count:";
            // 
            // productionPersonCountTextBox
            // 
            this.productionPersonCountTextBox.Location = new System.Drawing.Point(165, 228);
            this.productionPersonCountTextBox.Name = "productionPersonCountTextBox";
            this.productionPersonCountTextBox.Size = new System.Drawing.Size(121, 20);
            this.productionPersonCountTextBox.TabIndex = 56;
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(6, 257);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(153, 13);
            productionWorkshopNumberLabel.TabIndex = 57;
            productionWorkshopNumberLabel.Text = "Production Workshop Number:";
            // 
            // productionWorkshopNumberTextBox
            // 
            this.productionWorkshopNumberTextBox.Location = new System.Drawing.Point(165, 254);
            this.productionWorkshopNumberTextBox.Name = "productionWorkshopNumberTextBox";
            this.productionWorkshopNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.productionWorkshopNumberTextBox.TabIndex = 58;
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Location = new System.Drawing.Point(6, 283);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(88, 13);
            productTypeIDLabel.TabIndex = 59;
            productTypeIDLabel.Text = "Product Type ID:";
            // 
            // productTypeIDComboBox
            // 
            this.productTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductTypeID", true));
            this.productTypeIDComboBox.DataSource = this.productTypeBindingSource;
            this.productTypeIDComboBox.DisplayMember = "Title";
            this.productTypeIDComboBox.FormattingEnabled = true;
            this.productTypeIDComboBox.Location = new System.Drawing.Point(165, 280);
            this.productTypeIDComboBox.Name = "productTypeIDComboBox";
            this.productTypeIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.productTypeIDComboBox.TabIndex = 60;
            this.productTypeIDComboBox.ValueMember = "ID";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(6, 68);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 61;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(165, 65);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(121, 20);
            this.titleTextBox.TabIndex = 62;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(28, 326);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 43;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Выбор";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProdictPictureBox
            // 
            this.ProdictPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdictPictureBox.Location = new System.Drawing.Point(304, 38);
            this.ProdictPictureBox.Name = "ProdictPictureBox";
            this.ProdictPictureBox.Size = new System.Drawing.Size(142, 127);
            this.ProdictPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProdictPictureBox.TabIndex = 41;
            this.ProdictPictureBox.TabStop = false;
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(LopushokDemo.ProductType);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LopushokDemo.Product);
            // 
            // AddEditMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(this.articleNumberTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.minCostForAgentTextBox);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(this.productionPersonCountTextBox);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(this.productionWorkshopNumberTextBox);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(this.productTypeIDComboBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProdictPictureBox);
            this.Name = "AddEditMaterialForm";
            this.Text = "AddEditMaterialForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdictPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteMaterBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView productMaterialDataGridView;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox articleNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox minCostForAgentTextBox;
        private System.Windows.Forms.TextBox productionPersonCountTextBox;
        private System.Windows.Forms.TextBox productionWorkshopNumberTextBox;
        private System.Windows.Forms.ComboBox productTypeIDComboBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ProdictPictureBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
    }
}