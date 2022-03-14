namespace Bessonova483_ElectroShop
{
    partial class FormClientWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientWork));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.dateTimePickerRegisted = new System.Windows.Forms.DateTimePicker();
            this.labelRegisted = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelEmailClient = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labelDateBirth = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.clientsTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.ClientsTableAdapter();
            this.client_ManagerTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.Client_ManagerTableAdapter();
            this.usersTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter();
            this.labelClientList = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.dataGridViewListClient = new System.Windows.Forms.DataGridView();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.genderTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.GenderTableAdapter();
            this.listofClientsDataTableTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.ListofClientsDataTableTableAdapter();
            this.clientsTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.ClientsTableAdapter();
            this.genderTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.GenderTableAdapter();
            this.usersTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter();
            this.client_ManagerTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.Client_ManagerTableAdapter();
            this.listofClientsDataTableTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.ListofClientsDataTableTableAdapter();
            this.buttonRegClient = new System.Windows.Forms.Button();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.labelIdClient = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(843, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(207, 42);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(395, 20);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(168, 21);
            this.labelClient.TabIndex = 11;
            this.labelClient.Text = "Работа с клиентами";
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.dateTimePickerRegisted);
            this.groupBoxClient.Controls.Add(this.labelRegisted);
            this.groupBoxClient.Controls.Add(this.labelGender);
            this.groupBoxClient.Controls.Add(this.comboBoxGender);
            this.groupBoxClient.Controls.Add(this.labelEmailClient);
            this.groupBoxClient.Controls.Add(this.labelPhone);
            this.groupBoxClient.Controls.Add(this.textBoxEmail);
            this.groupBoxClient.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxClient.Controls.Add(this.dateTimePickerBirth);
            this.groupBoxClient.Controls.Add(this.labelDateBirth);
            this.groupBoxClient.Controls.Add(this.textBoxPatronymic);
            this.groupBoxClient.Controls.Add(this.labelPatronymic);
            this.groupBoxClient.Controls.Add(this.textBoxName);
            this.groupBoxClient.Controls.Add(this.labelName);
            this.groupBoxClient.Controls.Add(this.textBoxSurname);
            this.groupBoxClient.Controls.Add(this.labelSurname);
            this.groupBoxClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxClient.Location = new System.Drawing.Point(12, 93);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(609, 286);
            this.groupBoxClient.TabIndex = 13;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Данные клиента";
            // 
            // dateTimePickerRegisted
            // 
            this.dateTimePickerRegisted.Location = new System.Drawing.Point(409, 137);
            this.dateTimePickerRegisted.Name = "dateTimePickerRegisted";
            this.dateTimePickerRegisted.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerRegisted.TabIndex = 17;
            // 
            // labelRegisted
            // 
            this.labelRegisted.AutoSize = true;
            this.labelRegisted.Location = new System.Drawing.Point(312, 112);
            this.labelRegisted.Name = "labelRegisted";
            this.labelRegisted.Size = new System.Drawing.Size(153, 21);
            this.labelRegisted.TabIndex = 16;
            this.labelRegisted.Text = "Дата регистрации";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(395, 45);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 21);
            this.labelGender.TabIndex = 15;
            this.labelGender.Text = "Пол";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(443, 42);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(153, 29);
            this.comboBoxGender.TabIndex = 14;
            // 
            // labelEmailClient
            // 
            this.labelEmailClient.AutoSize = true;
            this.labelEmailClient.Location = new System.Drawing.Point(35, 241);
            this.labelEmailClient.Name = "labelEmailClient";
            this.labelEmailClient.Size = new System.Drawing.Size(51, 21);
            this.labelEmailClient.TabIndex = 13;
            this.labelEmailClient.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(24, 198);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(141, 21);
            this.labelPhone.TabIndex = 12;
            this.labelPhone.Text = "Номер телефона";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(105, 233);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(257, 29);
            this.textBoxEmail.TabIndex = 11;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(181, 198);
            this.maskedTextBoxPhone.Mask = "+7(000)000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(200, 29);
            this.maskedTextBoxPhone.TabIndex = 9;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(162, 151);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerBirth.TabIndex = 7;
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Location = new System.Drawing.Point(24, 157);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(132, 21);
            this.labelDateBirth.TabIndex = 6;
            this.labelDateBirth.Text = "Дата рождения";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(112, 112);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(187, 29);
            this.textBoxPatronymic.TabIndex = 5;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(24, 115);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(86, 21);
            this.labelPatronymic.TabIndex = 4;
            this.labelPatronymic.Text = "Отчество";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 29);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 21);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(112, 42);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(187, 29);
            this.textBoxSurname.TabIndex = 1;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(24, 45);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(82, 21);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // client_ManagerTableAdapter1
            // 
            this.client_ManagerTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // labelClientList
            // 
            this.labelClientList.AutoSize = true;
            this.labelClientList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientList.Location = new System.Drawing.Point(646, 81);
            this.labelClientList.Name = "labelClientList";
            this.labelClientList.Size = new System.Drawing.Size(149, 21);
            this.labelClientList.TabIndex = 15;
            this.labelClientList.Text = "Список клиентов";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddClient.Location = new System.Drawing.Point(12, 402);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(207, 42);
            this.buttonAddClient.TabIndex = 16;
            this.buttonAddClient.Text = "Внести клиента";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // dataGridViewListClient
            // 
            this.dataGridViewListClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListClient.Location = new System.Drawing.Point(641, 105);
            this.dataGridViewListClient.Name = "dataGridViewListClient";
            this.dataGridViewListClient.Size = new System.Drawing.Size(409, 333);
            this.dataGridViewListClient.TabIndex = 17;
            this.dataGridViewListClient.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListClient_RowEnter);
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateClient.Location = new System.Drawing.Point(242, 402);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(207, 42);
            this.buttonUpdateClient.TabIndex = 18;
            this.buttonUpdateClient.Text = "Обновить данные";
            this.buttonUpdateClient.UseVisualStyleBackColor = true;
            this.buttonUpdateClient.Click += new System.EventHandler(this.buttonUpdateClient_Click);
            // 
            // genderTableAdapter1
            // 
            this.genderTableAdapter1.ClearBeforeFill = true;
            // 
            // listofClientsDataTableTableAdapter1
            // 
            this.listofClientsDataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // clientsTableAdapter2
            // 
            this.clientsTableAdapter2.ClearBeforeFill = true;
            // 
            // genderTableAdapter2
            // 
            this.genderTableAdapter2.ClearBeforeFill = true;
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // client_ManagerTableAdapter2
            // 
            this.client_ManagerTableAdapter2.ClearBeforeFill = true;
            // 
            // listofClientsDataTableTableAdapter2
            // 
            this.listofClientsDataTableTableAdapter2.ClearBeforeFill = true;
            // 
            // buttonRegClient
            // 
            this.buttonRegClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegClient.Location = new System.Drawing.Point(455, 393);
            this.buttonRegClient.Name = "buttonRegClient";
            this.buttonRegClient.Size = new System.Drawing.Size(180, 51);
            this.buttonRegClient.TabIndex = 19;
            this.buttonRegClient.Text = "Регистрация клиента";
            this.buttonRegClient.UseVisualStyleBackColor = true;
            this.buttonRegClient.Click += new System.EventHandler(this.buttonRegClient_Click);
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdClient.Location = new System.Drawing.Point(290, 67);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(187, 29);
            this.textBoxIdClient.TabIndex = 21;
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdClient.Location = new System.Drawing.Point(255, 70);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(29, 21);
            this.labelIdClient.TabIndex = 20;
            this.labelIdClient.Text = "ID";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(8, 9);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 10;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormClientWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.textBoxIdClient);
            this.Controls.Add(this.labelIdClient);
            this.Controls.Add(this.buttonRegClient);
            this.Controls.Add(this.buttonUpdateClient);
            this.Controls.Add(this.dataGridViewListClient);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.labelClientList);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientWork";
            this.Text = "Работа с клиентами";
            this.Load += new System.EventHandler(this.FormClientWork_Load);
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private Bessonova483_ElectroShopDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labelDateBirth;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private Bessonova483_ElectroShopDataSetTableAdapters.Client_ManagerTableAdapter client_ManagerTableAdapter1;
        private Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Label labelClientList;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmailClient;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DataGridView dataGridViewListClient;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private Bessonova483_ElectroShopDataSetTableAdapters.GenderTableAdapter genderTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisted;
        private System.Windows.Forms.Label labelRegisted;
        private Bessonova483_ElectroShopDataSetTableAdapters.ListofClientsDataTableTableAdapter listofClientsDataTableTableAdapter1;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.ClientsTableAdapter clientsTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.GenderTableAdapter genderTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter usersTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.Client_ManagerTableAdapter client_ManagerTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.ListofClientsDataTableTableAdapter listofClientsDataTableTableAdapter2;
        private System.Windows.Forms.Button buttonRegClient;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.Label labelIdClient;
    }
}