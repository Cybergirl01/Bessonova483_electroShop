namespace Bessonova483_ElectroShop
{
    partial class FormUpdateObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateObject));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelObjects = new System.Windows.Forms.Label();
            this.dataGridViewObjects = new System.Windows.Forms.DataGridView();
            this.groupBoxObjectInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.dateTimePickerMade = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerResolution = new System.Windows.Forms.DateTimePicker();
            this.labelMade = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameObject = new System.Windows.Forms.TextBox();
            this.labelNameObject = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.objectsTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.ObjectsTableAdapter();
            this.objectsTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.ObjectsTableAdapter();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjects)).BeginInit();
            this.groupBoxObjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(581, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(207, 42);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelObjects
            // 
            this.labelObjects.AutoSize = true;
            this.labelObjects.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObjects.Location = new System.Drawing.Point(310, 9);
            this.labelObjects.Name = "labelObjects";
            this.labelObjects.Size = new System.Drawing.Size(159, 21);
            this.labelObjects.TabIndex = 36;
            this.labelObjects.Text = "Работа с товарами";
            // 
            // dataGridViewObjects
            // 
            this.dataGridViewObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjects.Location = new System.Drawing.Point(13, 112);
            this.dataGridViewObjects.Name = "dataGridViewObjects";
            this.dataGridViewObjects.Size = new System.Drawing.Size(355, 326);
            this.dataGridViewObjects.TabIndex = 38;
            this.dataGridViewObjects.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjects_RowEnter);
            // 
            // groupBoxObjectInfo
            // 
            this.groupBoxObjectInfo.Controls.Add(this.comboBoxCompany);
            this.groupBoxObjectInfo.Controls.Add(this.dateTimePickerMade);
            this.groupBoxObjectInfo.Controls.Add(this.dateTimePickerResolution);
            this.groupBoxObjectInfo.Controls.Add(this.labelMade);
            this.groupBoxObjectInfo.Controls.Add(this.labelResolution);
            this.groupBoxObjectInfo.Controls.Add(this.labelCompany);
            this.groupBoxObjectInfo.Controls.Add(this.labelCategory);
            this.groupBoxObjectInfo.Controls.Add(this.comboBoxCategory);
            this.groupBoxObjectInfo.Controls.Add(this.textBoxCost);
            this.groupBoxObjectInfo.Controls.Add(this.label1);
            this.groupBoxObjectInfo.Controls.Add(this.textBoxNameObject);
            this.groupBoxObjectInfo.Controls.Add(this.labelNameObject);
            this.groupBoxObjectInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxObjectInfo.Location = new System.Drawing.Point(375, 57);
            this.groupBoxObjectInfo.Name = "groupBoxObjectInfo";
            this.groupBoxObjectInfo.Size = new System.Drawing.Size(413, 303);
            this.groupBoxObjectInfo.TabIndex = 39;
            this.groupBoxObjectInfo.TabStop = false;
            this.groupBoxObjectInfo.Text = "Данные о товаре";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(134, 118);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(241, 29);
            this.comboBoxCompany.TabIndex = 60;
            // 
            // dateTimePickerMade
            // 
            this.dateTimePickerMade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerMade.Location = new System.Drawing.Point(144, 216);
            this.dateTimePickerMade.Name = "dateTimePickerMade";
            this.dateTimePickerMade.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerMade.TabIndex = 59;
            // 
            // dateTimePickerResolution
            // 
            this.dateTimePickerResolution.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerResolution.Location = new System.Drawing.Point(144, 162);
            this.dateTimePickerResolution.Name = "dateTimePickerResolution";
            this.dateTimePickerResolution.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerResolution.TabIndex = 58;
            // 
            // labelMade
            // 
            this.labelMade.AutoSize = true;
            this.labelMade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMade.Location = new System.Drawing.Point(34, 222);
            this.labelMade.Name = "labelMade";
            this.labelMade.Size = new System.Drawing.Size(78, 21);
            this.labelMade.TabIndex = 57;
            this.labelMade.Text = "Сделано";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.Location = new System.Drawing.Point(34, 170);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(104, 21);
            this.labelResolution.TabIndex = 56;
            this.labelResolution.Text = "Поставлено";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompany.Location = new System.Drawing.Point(37, 121);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(91, 21);
            this.labelCompany.TabIndex = 55;
            this.labelCompany.Text = "Компания";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(34, 77);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(94, 21);
            this.labelCategory.TabIndex = 54;
            this.labelCategory.Text = "Категория";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(134, 74);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(241, 29);
            this.comboBoxCategory.TabIndex = 53;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCost.Location = new System.Drawing.Point(113, 264);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 29);
            this.textBoxCost.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Цена";
            // 
            // textBoxNameObject
            // 
            this.textBoxNameObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameObject.Location = new System.Drawing.Point(134, 24);
            this.textBoxNameObject.Name = "textBoxNameObject";
            this.textBoxNameObject.Size = new System.Drawing.Size(241, 29);
            this.textBoxNameObject.TabIndex = 50;
            // 
            // labelNameObject
            // 
            this.labelNameObject.AutoSize = true;
            this.labelNameObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameObject.Location = new System.Drawing.Point(44, 32);
            this.labelNameObject.Name = "labelNameObject";
            this.labelNameObject.Size = new System.Drawing.Size(84, 21);
            this.labelNameObject.TabIndex = 49;
            this.labelNameObject.Text = "Название";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(375, 366);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(207, 42);
            this.buttonUpdate.TabIndex = 40;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // objectsTableAdapter1
            // 
            this.objectsTableAdapter1.ClearBeforeFill = true;
            // 
            // objectsTableAdapter2
            // 
            this.objectsTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 93);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 35;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormUpdateObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupBoxObjectInfo);
            this.Controls.Add(this.dataGridViewObjects);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelObjects);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUpdateObject";
            this.Text = "Работа с товарами";
            this.Load += new System.EventHandler(this.FormUpdateObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjects)).EndInit();
            this.groupBoxObjectInfo.ResumeLayout(false);
            this.groupBoxObjectInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelObjects;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridView dataGridViewObjects;
        private System.Windows.Forms.GroupBox groupBoxObjectInfo;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.DateTimePicker dateTimePickerMade;
        private System.Windows.Forms.DateTimePicker dateTimePickerResolution;
        private System.Windows.Forms.Label labelMade;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameObject;
        private System.Windows.Forms.Label labelNameObject;
        private System.Windows.Forms.Button buttonUpdate;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.ObjectsTableAdapter objectsTableAdapter1;
        private Bessonova483_ElectroShopDataSetTableAdapters.ObjectsTableAdapter objectsTableAdapter2;
    }
}