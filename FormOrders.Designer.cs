namespace Bessonova483_ElectroShop
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelObjectsOrder = new System.Windows.Forms.Label();
            this.buttonFormOrder = new System.Windows.Forms.Button();
            this.clientsTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.ClientsTableAdapter();
            this.ordersTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.OrdersTableAdapter();
            this.ordersTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.OrdersTableAdapter();
            this.clientsTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.ClientsTableAdapter();
            this.objectsTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.ObjectsTableAdapter();
            this.objectsTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.ObjectsTableAdapter();
            this.groupBoxObject = new System.Windows.Forms.GroupBox();
            this.labelItogo = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.labelObject = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelCLient = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelFinalSum = new System.Windows.Forms.Label();
            this.textBoxFInalSum = new System.Windows.Forms.TextBox();
            this.groupBoxObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(584, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(207, 42);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelObjectsOrder
            // 
            this.labelObjectsOrder.AutoSize = true;
            this.labelObjectsOrder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObjectsOrder.Location = new System.Drawing.Point(301, 9);
            this.labelObjectsOrder.Name = "labelObjectsOrder";
            this.labelObjectsOrder.Size = new System.Drawing.Size(178, 21);
            this.labelObjectsOrder.TabIndex = 36;
            this.labelObjectsOrder.Text = "Оформление заказов";
            // 
            // buttonFormOrder
            // 
            this.buttonFormOrder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormOrder.Location = new System.Drawing.Point(581, 396);
            this.buttonFormOrder.Name = "buttonFormOrder";
            this.buttonFormOrder.Size = new System.Drawing.Size(207, 42);
            this.buttonFormOrder.TabIndex = 38;
            this.buttonFormOrder.Text = "Оформить заказ";
            this.buttonFormOrder.UseVisualStyleBackColor = true;
            this.buttonFormOrder.Click += new System.EventHandler(this.buttonFormOrder_Click);
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter2
            // 
            this.ordersTableAdapter2.ClearBeforeFill = true;
            // 
            // clientsTableAdapter2
            // 
            this.clientsTableAdapter2.ClearBeforeFill = true;
            // 
            // objectsTableAdapter1
            // 
            this.objectsTableAdapter1.ClearBeforeFill = true;
            // 
            // objectsTableAdapter2
            // 
            this.objectsTableAdapter2.ClearBeforeFill = true;
            // 
            // groupBoxObject
            // 
            this.groupBoxObject.Controls.Add(this.labelItogo);
            this.groupBoxObject.Controls.Add(this.labelSum);
            this.groupBoxObject.Controls.Add(this.numericUpDownCount);
            this.groupBoxObject.Controls.Add(this.labelCount);
            this.groupBoxObject.Controls.Add(this.comboBoxObject);
            this.groupBoxObject.Controls.Add(this.labelObject);
            this.groupBoxObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxObject.Location = new System.Drawing.Point(13, 109);
            this.groupBoxObject.Name = "groupBoxObject";
            this.groupBoxObject.Size = new System.Drawing.Size(400, 201);
            this.groupBoxObject.TabIndex = 39;
            this.groupBoxObject.TabStop = false;
            this.groupBoxObject.Text = "Товар";
            // 
            // labelItogo
            // 
            this.labelItogo.AutoSize = true;
            this.labelItogo.Location = new System.Drawing.Point(136, 154);
            this.labelItogo.Name = "labelItogo";
            this.labelItogo.Size = new System.Drawing.Size(0, 21);
            this.labelItogo.TabIndex = 5;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(18, 154);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(99, 21);
            this.labelSum.TabIndex = 4;
            this.labelSum.Text = "Стоимость";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(156, 105);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownCount.TabIndex = 3;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(18, 107);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(105, 21);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "Количество";
            // 
            // comboBoxObject
            // 
            this.comboBoxObject.FormattingEnabled = true;
            this.comboBoxObject.Location = new System.Drawing.Point(156, 41);
            this.comboBoxObject.Name = "comboBoxObject";
            this.comboBoxObject.Size = new System.Drawing.Size(238, 29);
            this.comboBoxObject.TabIndex = 1;
            this.comboBoxObject.SelectedIndexChanged += new System.EventHandler(this.comboBoxObject_SelectedIndexChanged);
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.Location = new System.Drawing.Point(7, 42);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(142, 21);
            this.labelObject.TabIndex = 0;
            this.labelObject.Text = "Название товара";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(495, 138);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(220, 29);
            this.comboBoxClient.TabIndex = 40;
            // 
            // labelCLient
            // 
            this.labelCLient.AutoSize = true;
            this.labelCLient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCLient.Location = new System.Drawing.Point(436, 146);
            this.labelCLient.Name = "labelCLient";
            this.labelCLient.Size = new System.Drawing.Size(53, 21);
            this.labelCLient.TabIndex = 6;
            this.labelCLient.Text = "Кому";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 9);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 93);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 35;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelFinalSum
            // 
            this.labelFinalSum.AutoSize = true;
            this.labelFinalSum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalSum.Location = new System.Drawing.Point(27, 319);
            this.labelFinalSum.Name = "labelFinalSum";
            this.labelFinalSum.Size = new System.Drawing.Size(63, 21);
            this.labelFinalSum.TabIndex = 6;
            this.labelFinalSum.Text = "Итого:";
            // 
            // textBoxFInalSum
            // 
            this.textBoxFInalSum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFInalSum.Location = new System.Drawing.Point(105, 316);
            this.textBoxFInalSum.Name = "textBoxFInalSum";
            this.textBoxFInalSum.Size = new System.Drawing.Size(155, 29);
            this.textBoxFInalSum.TabIndex = 42;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxFInalSum);
            this.Controls.Add(this.labelFinalSum);
            this.Controls.Add(this.labelCLient);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.groupBoxObject);
            this.Controls.Add(this.buttonFormOrder);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelObjectsOrder);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrders";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.groupBoxObject.ResumeLayout(false);
            this.groupBoxObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelObjectsOrder;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonFormOrder;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private Bessonova483_ElectroShopDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.OrdersTableAdapter ordersTableAdapter2;
        private Bessonova483_ElectroShopDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter2;
        private Bessonova483_ElectroShopDataSetTableAdapters.ObjectsTableAdapter objectsTableAdapter1;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.ObjectsTableAdapter objectsTableAdapter2;
        private System.Windows.Forms.GroupBox groupBoxObject;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ComboBox comboBoxObject;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelItogo;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelCLient;
        private System.Windows.Forms.Label labelFinalSum;
        private System.Windows.Forms.TextBox textBoxFInalSum;
    }
}