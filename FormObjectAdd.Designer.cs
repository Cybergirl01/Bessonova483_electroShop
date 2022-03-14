namespace Bessonova483_ElectroShop
{
    partial class FormObjectAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObjectAdd));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelAdditionObject = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelNameObject = new System.Windows.Forms.Label();
            this.textBoxNameObject = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.objectsTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.ObjectsTableAdapter();
            this.categoryTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.CategoryTableAdapter();
            this.companyTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.CompanyTableAdapter();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelMade = new System.Windows.Forms.Label();
            this.dateTimePickerResolution = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMade = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveCode = new System.Windows.Forms.Button();
            this.buttonShowCode = new System.Windows.Forms.Button();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxCompany = new System.Windows.Forms.GroupBox();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.labelNameCompany = new System.Windows.Forms.Label();
            this.objectsTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.ObjectsTableAdapter();
            this.categoryTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.CategoryTableAdapter();
            this.companyTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.CompanyTableAdapter();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxCODE128 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCODE128)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(582, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(207, 42);
            this.buttonBack.TabIndex = 31;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelAdditionObject
            // 
            this.labelAdditionObject.AutoSize = true;
            this.labelAdditionObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdditionObject.Location = new System.Drawing.Point(250, 21);
            this.labelAdditionObject.Name = "labelAdditionObject";
            this.labelAdditionObject.Size = new System.Drawing.Size(163, 21);
            this.labelAdditionObject.TabIndex = 30;
            this.labelAdditionObject.Text = "Добавление товара";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 406);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(207, 42);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Добавить в продажу";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelNameObject
            // 
            this.labelNameObject.AutoSize = true;
            this.labelNameObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameObject.Location = new System.Drawing.Point(29, 119);
            this.labelNameObject.Name = "labelNameObject";
            this.labelNameObject.Size = new System.Drawing.Size(84, 21);
            this.labelNameObject.TabIndex = 33;
            this.labelNameObject.Text = "Название";
            // 
            // textBoxNameObject
            // 
            this.textBoxNameObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameObject.Location = new System.Drawing.Point(119, 116);
            this.textBoxNameObject.Name = "textBoxNameObject";
            this.textBoxNameObject.Size = new System.Drawing.Size(241, 29);
            this.textBoxNameObject.TabIndex = 34;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCost.Location = new System.Drawing.Point(98, 351);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 29);
            this.textBoxCost.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Цена";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(119, 161);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(241, 29);
            this.comboBoxCategory.TabIndex = 37;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(19, 164);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(94, 21);
            this.labelCategory.TabIndex = 38;
            this.labelCategory.Text = "Категория";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompany.Location = new System.Drawing.Point(22, 208);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(91, 21);
            this.labelCompany.TabIndex = 39;
            this.labelCompany.Text = "Компания";
            // 
            // objectsTableAdapter1
            // 
            this.objectsTableAdapter1.ClearBeforeFill = true;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // companyTableAdapter1
            // 
            this.companyTableAdapter1.ClearBeforeFill = true;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.Location = new System.Drawing.Point(19, 257);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(104, 21);
            this.labelResolution.TabIndex = 41;
            this.labelResolution.Text = "Поставлено";
            // 
            // labelMade
            // 
            this.labelMade.AutoSize = true;
            this.labelMade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMade.Location = new System.Drawing.Point(19, 309);
            this.labelMade.Name = "labelMade";
            this.labelMade.Size = new System.Drawing.Size(78, 21);
            this.labelMade.TabIndex = 42;
            this.labelMade.Text = "Сделано";
            // 
            // dateTimePickerResolution
            // 
            this.dateTimePickerResolution.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerResolution.Location = new System.Drawing.Point(129, 249);
            this.dateTimePickerResolution.Name = "dateTimePickerResolution";
            this.dateTimePickerResolution.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerResolution.TabIndex = 43;
            // 
            // dateTimePickerMade
            // 
            this.dateTimePickerMade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerMade.Location = new System.Drawing.Point(129, 303);
            this.dateTimePickerMade.Name = "dateTimePickerMade";
            this.dateTimePickerMade.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerMade.TabIndex = 44;
            // 
            // buttonSaveCode
            // 
            this.buttonSaveCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveCode.Location = new System.Drawing.Point(582, 263);
            this.buttonSaveCode.Name = "buttonSaveCode";
            this.buttonSaveCode.Size = new System.Drawing.Size(194, 42);
            this.buttonSaveCode.TabIndex = 46;
            this.buttonSaveCode.Text = "Сохранить штрих-код";
            this.buttonSaveCode.UseVisualStyleBackColor = true;
            this.buttonSaveCode.Click += new System.EventHandler(this.buttonSaveCode_Click);
            // 
            // buttonShowCode
            // 
            this.buttonShowCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowCode.Location = new System.Drawing.Point(582, 215);
            this.buttonShowCode.Name = "buttonShowCode";
            this.buttonShowCode.Size = new System.Drawing.Size(194, 42);
            this.buttonShowCode.TabIndex = 47;
            this.buttonShowCode.Text = "Показать штрих-код";
            this.buttonShowCode.UseVisualStyleBackColor = true;
            this.buttonShowCode.Click += new System.EventHandler(this.buttonShowCode_Click);
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(119, 205);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(241, 29);
            this.comboBoxCompany.TabIndex = 48;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddImage.Location = new System.Drawing.Point(382, 215);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(194, 63);
            this.buttonAddImage.TabIndex = 50;
            this.buttonAddImage.Text = "Добавить изображение";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBoxCompany
            // 
            this.groupBoxCompany.Controls.Add(this.buttonAddCompany);
            this.groupBoxCompany.Controls.Add(this.textBoxCompany);
            this.groupBoxCompany.Controls.Add(this.labelNameCompany);
            this.groupBoxCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCompany.Location = new System.Drawing.Point(344, 338);
            this.groupBoxCompany.Name = "groupBoxCompany";
            this.groupBoxCompany.Size = new System.Drawing.Size(432, 110);
            this.groupBoxCompany.TabIndex = 51;
            this.groupBoxCompany.TabStop = false;
            this.groupBoxCompany.Text = "Добавление компании";
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCompany.Location = new System.Drawing.Point(16, 62);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(207, 42);
            this.buttonAddCompany.TabIndex = 52;
            this.buttonAddCompany.Text = "Добавить компанию";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            this.buttonAddCompany.Click += new System.EventHandler(this.buttonAddCompany_Click);
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCompany.Location = new System.Drawing.Point(209, 28);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(202, 29);
            this.textBoxCompany.TabIndex = 52;
            // 
            // labelNameCompany
            // 
            this.labelNameCompany.AutoSize = true;
            this.labelNameCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCompany.Location = new System.Drawing.Point(34, 31);
            this.labelNameCompany.Name = "labelNameCompany";
            this.labelNameCompany.Size = new System.Drawing.Size(167, 21);
            this.labelNameCompany.TabIndex = 52;
            this.labelNameCompany.Text = "Название компании";
            // 
            // objectsTableAdapter2
            // 
            this.objectsTableAdapter2.ClearBeforeFill = true;
            // 
            // categoryTableAdapter2
            // 
            this.categoryTableAdapter2.ClearBeforeFill = true;
            // 
            // companyTableAdapter2
            // 
            this.companyTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(382, 97);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(194, 112);
            this.pictureBoxImage.TabIndex = 49;
            this.pictureBoxImage.TabStop = false;
            // 
            // pictureBoxCODE128
            // 
            this.pictureBoxCODE128.Location = new System.Drawing.Point(582, 97);
            this.pictureBoxCODE128.Name = "pictureBoxCODE128";
            this.pictureBoxCODE128.Size = new System.Drawing.Size(194, 112);
            this.pictureBoxCODE128.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCODE128.TabIndex = 45;
            this.pictureBoxCODE128.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(13, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 93);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 29;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormObjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCompany);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.buttonShowCode);
            this.Controls.Add(this.buttonSaveCode);
            this.Controls.Add(this.pictureBoxCODE128);
            this.Controls.Add(this.dateTimePickerMade);
            this.Controls.Add(this.dateTimePickerResolution);
            this.Controls.Add(this.labelMade);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameObject);
            this.Controls.Add(this.labelNameObject);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAdditionObject);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormObjectAdd";
            this.Text = "Добавление товара";
            this.Load += new System.EventHandler(this.FormObjectAdd_Load);
            this.groupBoxCompany.ResumeLayout(false);
            this.groupBoxCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCODE128)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAdditionObject;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonAdd;
        private Bessonova483_ElectroShopDataSetTableAdapters.ObjectsTableAdapter objectsTableAdapter1;
        private Bessonova483_ElectroShopDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private Bessonova483_ElectroShopDataSetTableAdapters.CompanyTableAdapter companyTableAdapter1;
        private System.Windows.Forms.Label labelNameObject;
        private System.Windows.Forms.TextBox textBoxNameObject;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelMade;
        private System.Windows.Forms.DateTimePicker dateTimePickerResolution;
        private System.Windows.Forms.DateTimePicker dateTimePickerMade;
        private System.Windows.Forms.PictureBox pictureBoxCODE128;
        private System.Windows.Forms.Button buttonSaveCode;
        private System.Windows.Forms.Button buttonShowCode;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxCompany;
        private System.Windows.Forms.Button buttonAddCompany;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label labelNameCompany;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.ObjectsTableAdapter objectsTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.CategoryTableAdapter categoryTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.CompanyTableAdapter companyTableAdapter2;
    }
}