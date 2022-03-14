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
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelCLient = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelFinalSum = new System.Windows.Forms.Label();
            this.textBoxItog = new System.Windows.Forms.TextBox();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.dataGridViewObjects = new System.Windows.Forms.DataGridView();
            this.textBoxObject = new System.Windows.Forms.TextBox();
            this.labelObject = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjects)).BeginInit();
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
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(557, 57);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(220, 29);
            this.comboBoxClient.TabIndex = 40;
            // 
            // labelCLient
            // 
            this.labelCLient.AutoSize = true;
            this.labelCLient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCLient.Location = new System.Drawing.Point(498, 65);
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
            this.labelFinalSum.Location = new System.Drawing.Point(22, 399);
            this.labelFinalSum.Name = "labelFinalSum";
            this.labelFinalSum.Size = new System.Drawing.Size(63, 21);
            this.labelFinalSum.TabIndex = 6;
            this.labelFinalSum.Text = "Итого:";
            // 
            // textBoxItog
            // 
            this.textBoxItog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxItog.Location = new System.Drawing.Point(163, 396);
            this.textBoxItog.Name = "textBoxItog";
            this.textBoxItog.Size = new System.Drawing.Size(155, 29);
            this.textBoxItog.TabIndex = 42;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCount.Location = new System.Drawing.Point(668, 224);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownCount.TabIndex = 3;
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.numericUpDownCount_ValueChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(520, 232);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(105, 21);
            this.labelCount.TabIndex = 43;
            this.labelCount.Text = "Количество";
            // 
            // dataGridViewObjects
            // 
            this.dataGridViewObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjects.Location = new System.Drawing.Point(13, 109);
            this.dataGridViewObjects.Name = "dataGridViewObjects";
            this.dataGridViewObjects.Size = new System.Drawing.Size(400, 281);
            this.dataGridViewObjects.TabIndex = 44;
            this.dataGridViewObjects.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjects_RowEnter);
            // 
            // textBoxObject
            // 
            this.textBoxObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxObject.Location = new System.Drawing.Point(636, 128);
            this.textBoxObject.Name = "textBoxObject";
            this.textBoxObject.Size = new System.Drawing.Size(155, 29);
            this.textBoxObject.TabIndex = 46;
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObject.Location = new System.Drawing.Point(512, 131);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(58, 21);
            this.labelObject.TabIndex = 45;
            this.labelObject.Text = "Товар";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.Location = new System.Drawing.Point(633, 174);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(155, 29);
            this.textBoxID.TabIndex = 48;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(530, 182);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(63, 21);
            this.labelID.TabIndex = 47;
            this.labelID.Text = "Номер";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCost.Location = new System.Drawing.Point(636, 282);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(155, 29);
            this.textBoxCost.TabIndex = 50;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(530, 285);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(49, 21);
            this.labelCost.TabIndex = 49;
            this.labelCost.Text = "Цена";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxObject);
            this.Controls.Add(this.labelObject);
            this.Controls.Add(this.dataGridViewObjects);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxItog);
            this.Controls.Add(this.labelFinalSum);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.labelCLient);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.buttonFormOrder);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelObjectsOrder);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrders";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjects)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelCLient;
        private System.Windows.Forms.Label labelFinalSum;
        private System.Windows.Forms.TextBox textBoxItog;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.DataGridView dataGridViewObjects;
        private System.Windows.Forms.TextBox textBoxObject;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelCost;
    }
}