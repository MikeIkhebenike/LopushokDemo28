
namespace LopushokDemo
{
    partial class AddEditMaterialForm
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
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label materialIDLabel;
            System.Windows.Forms.Label productIDLabel;
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.materialIDComboBox = new System.Windows.Forms.ComboBox();
            this.productMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            countLabel = new System.Windows.Forms.Label();
            materialIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(44, 90);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 13;
            countLabel.Text = "Count:";
            // 
            // materialIDLabel
            // 
            materialIDLabel.AutoSize = true;
            materialIDLabel.Location = new System.Drawing.Point(21, 61);
            materialIDLabel.Name = "materialIDLabel";
            materialIDLabel.Size = new System.Drawing.Size(61, 13);
            materialIDLabel.TabIndex = 17;
            materialIDLabel.Text = "Material ID:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(21, 27);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 19;
            productIDLabel.Text = "Product ID:";
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(88, 87);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(121, 20);
            this.countTextBox.TabIndex = 16;
            // 
            // materialIDComboBox
            // 
            this.materialIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productMaterialBindingSource, "MaterialID", true));
            this.materialIDComboBox.DataSource = this.materialBindingSource;
            this.materialIDComboBox.DisplayMember = "Title";
            this.materialIDComboBox.FormattingEnabled = true;
            this.materialIDComboBox.Location = new System.Drawing.Point(88, 53);
            this.materialIDComboBox.Name = "materialIDComboBox";
            this.materialIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.materialIDComboBox.TabIndex = 18;
            this.materialIDComboBox.ValueMember = "ID";
            // 
            // productMaterialBindingSource
            // 
            this.productMaterialBindingSource.DataSource = typeof(LopushokDemo.ProductMaterial);
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(LopushokDemo.Material);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(88, 20);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.productIDTextBox.TabIndex = 20;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(152, 123);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(11, 123);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LopushokDemo.Product);
            // 
            // AddEditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 433);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(materialIDLabel);
            this.Controls.Add(this.materialIDComboBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Name = "AddEditProductForm";
            this.Text = "AddEditProductForm";
            this.Load += new System.EventHandler(this.AddEditMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.ComboBox materialIDComboBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.BindingSource productMaterialBindingSource;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}