namespace Bessonova483_ElectroShop
{
    partial class FormManagerSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerSale));
            this.labelManagerProduct = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonClientWork = new System.Windows.Forms.Button();
            this.usersTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter();
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.usersTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManagerProduct
            // 
            this.labelManagerProduct.AutoSize = true;
            this.labelManagerProduct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManagerProduct.Location = new System.Drawing.Point(283, 44);
            this.labelManagerProduct.Name = "labelManagerProduct";
            this.labelManagerProduct.Size = new System.Drawing.Size(254, 21);
            this.labelManagerProduct.TabIndex = 3;
            this.labelManagerProduct.Text = "Форма менеджера по продаже";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 93);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogOut.Location = new System.Drawing.Point(581, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(207, 42);
            this.buttonLogOut.TabIndex = 9;
            this.buttonLogOut.Text = "Выйти";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProfile.Location = new System.Drawing.Point(257, 93);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(323, 42);
            this.buttonProfile.TabIndex = 10;
            this.buttonProfile.Text = "Просмотеть профиль";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonClientWork
            // 
            this.buttonClientWork.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientWork.Location = new System.Drawing.Point(257, 164);
            this.buttonClientWork.Name = "buttonClientWork";
            this.buttonClientWork.Size = new System.Drawing.Size(323, 42);
            this.buttonClientWork.TabIndex = 11;
            this.buttonClientWork.Text = "Работа с клиентами";
            this.buttonClientWork.UseVisualStyleBackColor = true;
            this.buttonClientWork.Click += new System.EventHandler(this.buttonClientWork_Click);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddObject.Location = new System.Drawing.Point(257, 232);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(323, 42);
            this.buttonAddObject.TabIndex = 12;
            this.buttonAddObject.Text = "Работа с товарами";
            this.buttonAddObject.UseVisualStyleBackColor = true;
            this.buttonAddObject.Click += new System.EventHandler(this.buttonAddObject_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.Location = new System.Drawing.Point(257, 298);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(323, 42);
            this.buttonOrders.TabIndex = 13;
            this.buttonOrders.Text = "Работа с заказами";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // FormManagerSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonAddObject);
            this.Controls.Add(this.buttonClientWork);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelManagerProduct);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManagerSale";
            this.Text = "Форма менеджера по продаже";
            this.Load += new System.EventHandler(this.FormManagerSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManagerProduct;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonClientWork;
        private Bessonova483_ElectroShopDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Button buttonAddObject;
        private System.Windows.Forms.Button buttonOrders;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.UsersTableAdapter usersTableAdapter2;
    }
}