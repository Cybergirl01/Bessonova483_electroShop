﻿namespace Bessonova483_ElectroShop
{
    partial class FormManagerProductProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerProductProfile));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelManagerProductProfile = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.usersTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBoxDataget = new System.Windows.Forms.GroupBox();
            this.textBoxPatromynic = new System.Windows.Forms.TextBox();
            this.labelPatromynic = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.dateTimePickerRegisted = new System.Windows.Forms.DateTimePicker();
            this.labelRegisted = new System.Windows.Forms.Label();
            this.groupBoxnonchangedata = new System.Windows.Forms.GroupBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelLog_Email = new System.Windows.Forms.Label();
            this.labelNumID = new System.Windows.Forms.Label();
            this.genderTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.GenderTableAdapter();
            this.usersTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter();
            this.genderTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.GenderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxDataget.SuspendLayout();
            this.groupBoxnonchangedata.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(581, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(207, 42);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelManagerProductProfile
            // 
            this.labelManagerProductProfile.AutoSize = true;
            this.labelManagerProductProfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManagerProductProfile.Location = new System.Drawing.Point(232, 24);
            this.labelManagerProductProfile.Name = "labelManagerProductProfile";
            this.labelManagerProductProfile.Size = new System.Drawing.Size(273, 21);
            this.labelManagerProductProfile.TabIndex = 11;
            this.labelManagerProductProfile.Text = "Профиль менеджера по продаже";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 93);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 10;
            this.pictureBoxLogo.TabStop = false;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.buttonUpdate.Location = new System.Drawing.Point(12, 389);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(205, 49);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "Обновить профиль";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBoxDataget
            // 
            this.groupBoxDataget.Controls.Add(this.textBoxPatromynic);
            this.groupBoxDataget.Controls.Add(this.labelPatromynic);
            this.groupBoxDataget.Controls.Add(this.comboBoxGender);
            this.groupBoxDataget.Controls.Add(this.textBoxLastname);
            this.groupBoxDataget.Controls.Add(this.textBoxFirstName);
            this.groupBoxDataget.Controls.Add(this.labelFirstName);
            this.groupBoxDataget.Controls.Add(this.labelGender);
            this.groupBoxDataget.Controls.Add(this.labelLastName);
            this.groupBoxDataget.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataget.Location = new System.Drawing.Point(320, 61);
            this.groupBoxDataget.Name = "groupBoxDataget";
            this.groupBoxDataget.Size = new System.Drawing.Size(468, 301);
            this.groupBoxDataget.TabIndex = 23;
            this.groupBoxDataget.TabStop = false;
            this.groupBoxDataget.Text = "Доступные данные";
            // 
            // textBoxPatromynic
            // 
            this.textBoxPatromynic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatromynic.Location = new System.Drawing.Point(147, 131);
            this.textBoxPatromynic.Name = "textBoxPatromynic";
            this.textBoxPatromynic.Size = new System.Drawing.Size(221, 29);
            this.textBoxPatromynic.TabIndex = 15;
            // 
            // labelPatromynic
            // 
            this.labelPatromynic.AutoSize = true;
            this.labelPatromynic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatromynic.Location = new System.Drawing.Point(38, 135);
            this.labelPatromynic.Name = "labelPatromynic";
            this.labelPatromynic.Size = new System.Drawing.Size(86, 21);
            this.labelPatromynic.TabIndex = 16;
            this.labelPatromynic.Text = "Отчество";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(143, 180);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(225, 29);
            this.comboBoxGender.TabIndex = 13;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastname.Location = new System.Drawing.Point(143, 39);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(225, 29);
            this.textBoxLastname.TabIndex = 12;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(147, 82);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(221, 29);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(38, 85);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(44, 21);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "Имя";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(38, 180);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 21);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Пол";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(38, 39);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(82, 21);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Фамилия";
            // 
            // dateTimePickerRegisted
            // 
            this.dateTimePickerRegisted.Location = new System.Drawing.Point(136, 141);
            this.dateTimePickerRegisted.Name = "dateTimePickerRegisted";
            this.dateTimePickerRegisted.Size = new System.Drawing.Size(165, 26);
            this.dateTimePickerRegisted.TabIndex = 14;
            // 
            // labelRegisted
            // 
            this.labelRegisted.AutoSize = true;
            this.labelRegisted.Location = new System.Drawing.Point(-1, 148);
            this.labelRegisted.Name = "labelRegisted";
            this.labelRegisted.Size = new System.Drawing.Size(131, 19);
            this.labelRegisted.TabIndex = 9;
            this.labelRegisted.Text = "Дата регистрации";
            // 
            // groupBoxnonchangedata
            // 
            this.groupBoxnonchangedata.Controls.Add(this.checkBoxStatus);
            this.groupBoxnonchangedata.Controls.Add(this.labelPass);
            this.groupBoxnonchangedata.Controls.Add(this.dateTimePickerRegisted);
            this.groupBoxnonchangedata.Controls.Add(this.labelLog_Email);
            this.groupBoxnonchangedata.Controls.Add(this.labelNumID);
            this.groupBoxnonchangedata.Controls.Add(this.labelRegisted);
            this.groupBoxnonchangedata.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxnonchangedata.Location = new System.Drawing.Point(13, 110);
            this.groupBoxnonchangedata.Name = "groupBoxnonchangedata";
            this.groupBoxnonchangedata.Size = new System.Drawing.Size(301, 228);
            this.groupBoxnonchangedata.TabIndex = 22;
            this.groupBoxnonchangedata.TabStop = false;
            this.groupBoxnonchangedata.Text = "Недоступные данные";
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(22, 180);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(146, 23);
            this.checkBoxStatus.TabIndex = 3;
            this.checkBoxStatus.Text = "Доступ к системе";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(18, 120);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(45, 19);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "label3";
            // 
            // labelLog_Email
            // 
            this.labelLog_Email.AutoSize = true;
            this.labelLog_Email.Location = new System.Drawing.Point(18, 79);
            this.labelLog_Email.Name = "labelLog_Email";
            this.labelLog_Email.Size = new System.Drawing.Size(45, 19);
            this.labelLog_Email.TabIndex = 1;
            this.labelLog_Email.Text = "label2";
            // 
            // labelNumID
            // 
            this.labelNumID.AutoSize = true;
            this.labelNumID.Location = new System.Drawing.Point(18, 38);
            this.labelNumID.Name = "labelNumID";
            this.labelNumID.Size = new System.Drawing.Size(45, 19);
            this.labelNumID.TabIndex = 0;
            this.labelNumID.Text = "label1";
            // 
            // genderTableAdapter1
            // 
            this.genderTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // genderTableAdapter2
            // 
            this.genderTableAdapter2.ClearBeforeFill = true;
            // 
            // FormManagerProductProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupBoxDataget);
            this.Controls.Add(this.groupBoxnonchangedata);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelManagerProductProfile);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManagerProductProfile";
            this.Text = "профиль менеджера по продаже";
            this.Load += new System.EventHandler(this.FormManagerProductProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxDataget.ResumeLayout(false);
            this.groupBoxDataget.PerformLayout();
            this.groupBoxnonchangedata.ResumeLayout(false);
            this.groupBoxnonchangedata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelManagerProductProfile;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBoxDataget;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisted;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelRegisted;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.GroupBox groupBoxnonchangedata;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelLog_Email;
        private System.Windows.Forms.Label labelNumID;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.TextBox textBoxPatromynic;
        private System.Windows.Forms.Label labelPatromynic;
        private Bessonova483_ElectroShopDataSetTableAdapters.GenderTableAdapter genderTableAdapter1;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter usersTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.GenderTableAdapter genderTableAdapter2;
    }
}