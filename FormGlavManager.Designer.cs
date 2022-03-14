namespace Bessonova483_ElectroShop
{
    partial class FormGlavManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlavManager));
            this.buttonObjects = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelManagerProduct = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter();
            this.buttonDocumentWork = new System.Windows.Forms.Button();
            this.usersTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObjects
            // 
            this.buttonObjects.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonObjects.Location = new System.Drawing.Point(245, 172);
            this.buttonObjects.Name = "buttonObjects";
            this.buttonObjects.Size = new System.Drawing.Size(323, 42);
            this.buttonObjects.TabIndex = 16;
            this.buttonObjects.Text = "Работа с товарами";
            this.buttonObjects.UseVisualStyleBackColor = true;
            this.buttonObjects.Click += new System.EventHandler(this.buttonObjects_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProfile.Location = new System.Drawing.Point(245, 96);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(323, 42);
            this.buttonProfile.TabIndex = 15;
            this.buttonProfile.Text = "Просмотеть профиль";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogOut.Location = new System.Drawing.Point(581, 9);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(207, 42);
            this.buttonLogOut.TabIndex = 14;
            this.buttonLogOut.Text = "Выйти";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelManagerProduct
            // 
            this.labelManagerProduct.AutoSize = true;
            this.labelManagerProduct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManagerProduct.Location = new System.Drawing.Point(277, 20);
            this.labelManagerProduct.Name = "labelManagerProduct";
            this.labelManagerProduct.Size = new System.Drawing.Size(232, 21);
            this.labelManagerProduct.TabIndex = 13;
            this.labelManagerProduct.Text = "Форма главного менеджера";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonDocumentWork
            // 
            this.buttonDocumentWork.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDocumentWork.Location = new System.Drawing.Point(245, 246);
            this.buttonDocumentWork.Name = "buttonDocumentWork";
            this.buttonDocumentWork.Size = new System.Drawing.Size(323, 42);
            this.buttonDocumentWork.TabIndex = 17;
            this.buttonDocumentWork.Text = "Работа с документами";
            this.buttonDocumentWork.UseVisualStyleBackColor = true;
            this.buttonDocumentWork.Click += new System.EventHandler(this.buttonDocumentWork_Click);
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // FormGlavManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDocumentWork);
            this.Controls.Add(this.buttonObjects);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelManagerProduct);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGlavManager";
            this.Text = "Форма главного менеджера";
            this.Load += new System.EventHandler(this.FormGlavManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonObjects;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelManagerProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Button buttonDocumentWork;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter usersTableAdapter2;
    }
}