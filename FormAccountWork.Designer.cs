namespace Bessonova483_ElectroShop
{
    partial class FormAccountWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountWork));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelAccountwork = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewListAccount = new System.Windows.Forms.DataGridView();
            this.labelList = new System.Windows.Forms.Label();
            this.groupBoxAccountRegister = new System.Windows.Forms.GroupBox();
            this.textBoxRegisted = new System.Windows.Forms.TextBox();
            this.labelRegisted = new System.Windows.Forms.Label();
            this.checkBoxSystem = new System.Windows.Forms.CheckBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPas = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.usersTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter();
            this.rolesTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.RolesTableAdapter();
            this.genderTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.GenderTableAdapter();
            this.usersTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter();
            this.rolesTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.RolesTableAdapter();
            this.genderTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.GenderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAccount)).BeginInit();
            this.groupBoxAccountRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(878, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(207, 42);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelAccountwork
            // 
            this.labelAccountwork.AutoSize = true;
            this.labelAccountwork.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccountwork.Location = new System.Drawing.Point(284, 25);
            this.labelAccountwork.Name = "labelAccountwork";
            this.labelAccountwork.Size = new System.Drawing.Size(174, 21);
            this.labelAccountwork.TabIndex = 13;
            this.labelAccountwork.Text = "Работа с аккаунтами";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 93);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // dataGridViewListAccount
            // 
            this.dataGridViewListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAccount.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewListAccount.Name = "dataGridViewListAccount";
            this.dataGridViewListAccount.Size = new System.Drawing.Size(446, 334);
            this.dataGridViewListAccount.TabIndex = 15;
            this.dataGridViewListAccount.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListAccount_RowEnter);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelList.Location = new System.Drawing.Point(127, 76);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(192, 21);
            this.labelList.TabIndex = 16;
            this.labelList.Text = "Список пользователей";
            // 
            // groupBoxAccountRegister
            // 
            this.groupBoxAccountRegister.Controls.Add(this.textBoxRegisted);
            this.groupBoxAccountRegister.Controls.Add(this.labelRegisted);
            this.groupBoxAccountRegister.Controls.Add(this.checkBoxSystem);
            this.groupBoxAccountRegister.Controls.Add(this.textBoxPass);
            this.groupBoxAccountRegister.Controls.Add(this.textBoxEmail);
            this.groupBoxAccountRegister.Controls.Add(this.labelPas);
            this.groupBoxAccountRegister.Controls.Add(this.labelEmail);
            this.groupBoxAccountRegister.Controls.Add(this.comboBoxGender);
            this.groupBoxAccountRegister.Controls.Add(this.labelGender);
            this.groupBoxAccountRegister.Controls.Add(this.textBoxPatronymic);
            this.groupBoxAccountRegister.Controls.Add(this.textBoxName);
            this.groupBoxAccountRegister.Controls.Add(this.textBoxSurname);
            this.groupBoxAccountRegister.Controls.Add(this.labelPatronymic);
            this.groupBoxAccountRegister.Controls.Add(this.labelName);
            this.groupBoxAccountRegister.Controls.Add(this.labelSurname);
            this.groupBoxAccountRegister.Controls.Add(this.labelRole);
            this.groupBoxAccountRegister.Controls.Add(this.comboBoxRole);
            this.groupBoxAccountRegister.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAccountRegister.Location = new System.Drawing.Point(501, 52);
            this.groupBoxAccountRegister.Name = "groupBoxAccountRegister";
            this.groupBoxAccountRegister.Size = new System.Drawing.Size(584, 339);
            this.groupBoxAccountRegister.TabIndex = 17;
            this.groupBoxAccountRegister.TabStop = false;
            this.groupBoxAccountRegister.Text = "Регистрация";
            // 
            // textBoxRegisted
            // 
            this.textBoxRegisted.Location = new System.Drawing.Point(342, 204);
            this.textBoxRegisted.Name = "textBoxRegisted";
            this.textBoxRegisted.Size = new System.Drawing.Size(236, 29);
            this.textBoxRegisted.TabIndex = 16;
            // 
            // labelRegisted
            // 
            this.labelRegisted.AutoSize = true;
            this.labelRegisted.Location = new System.Drawing.Point(279, 180);
            this.labelRegisted.Name = "labelRegisted";
            this.labelRegisted.Size = new System.Drawing.Size(148, 21);
            this.labelRegisted.TabIndex = 15;
            this.labelRegisted.Text = "Зарегистрирован";
            // 
            // checkBoxSystem
            // 
            this.checkBoxSystem.AutoSize = true;
            this.checkBoxSystem.Location = new System.Drawing.Point(377, 296);
            this.checkBoxSystem.Name = "checkBoxSystem";
            this.checkBoxSystem.Size = new System.Drawing.Size(171, 25);
            this.checkBoxSystem.TabIndex = 14;
            this.checkBoxSystem.Text = "Доступ к системе";
            this.checkBoxSystem.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(94, 281);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(206, 29);
            this.textBoxPass.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(70, 232);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(206, 29);
            this.textBoxEmail.TabIndex = 12;
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(19, 284);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(69, 21);
            this.labelPas.TabIndex = 11;
            this.labelPas.Text = "Пароль";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(18, 235);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 21);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(70, 177);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(200, 29);
            this.comboBoxGender.TabIndex = 9;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(22, 180);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 21);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Пол";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(114, 120);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(206, 29);
            this.textBoxPatronymic.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(73, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(206, 29);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(103, 26);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(206, 29);
            this.textBoxSurname.TabIndex = 5;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(22, 123);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(86, 21);
            this.labelPatronymic.TabIndex = 4;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 21);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(15, 29);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(82, 21);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(322, 31);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(49, 21);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Роль";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(377, 28);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(200, 29);
            this.comboBoxRole.TabIndex = 0;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(501, 397);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(346, 42);
            this.buttonRegister.TabIndex = 18;
            this.buttonRegister.Text = "Внести нового пользователя в систему";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(878, 397);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(207, 42);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Регистрировать";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // rolesTableAdapter1
            // 
            this.rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // genderTableAdapter1
            // 
            this.genderTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // rolesTableAdapter2
            // 
            this.rolesTableAdapter2.ClearBeforeFill = true;
            // 
            // genderTableAdapter2
            // 
            this.genderTableAdapter2.ClearBeforeFill = true;
            // 
            // FormAccountWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.groupBoxAccountRegister);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.dataGridViewListAccount);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAccountwork);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccountWork";
            this.Text = "Работа с аккаунтами";
            this.Load += new System.EventHandler(this.FormAccountWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAccount)).EndInit();
            this.groupBoxAccountRegister.ResumeLayout(false);
            this.groupBoxAccountRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAccountwork;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridView dataGridViewListAccount;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.GroupBox groupBoxAccountRegister;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.Label labelEmail;
        private Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private Bessonova483_ElectroShopDataSetTableAdapters.RolesTableAdapter rolesTableAdapter1;
        private Bessonova483_ElectroShopDataSetTableAdapters.GenderTableAdapter genderTableAdapter1;
        private System.Windows.Forms.CheckBox checkBoxSystem;
        private System.Windows.Forms.TextBox textBoxRegisted;
        private System.Windows.Forms.Label labelRegisted;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter usersTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.RolesTableAdapter rolesTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.GenderTableAdapter genderTableAdapter2;
    }
}