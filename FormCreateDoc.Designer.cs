
namespace Bessonova483_ElectroShop
{
    partial class FormCreateDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateDoc));
            this.button2 = new System.Windows.Forms.Button();
            this.labelDoc = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonСreate = new System.Windows.Forms.Button();
            this.labelIDOrder = new System.Windows.Forms.Label();
            this.textBoxIDorder = new System.Windows.Forms.TextBox();
            this.textBoxIDClient = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxIDObject = new System.Windows.Forms.TextBox();
            this.labelObject = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.ordersTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.OrdersTableAdapter();
            this.ordersTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.OrdersTableAdapter();
            this.clientsTableAdapter1 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSethomeTableAdapters.ClientsTableAdapter();
            this.clientsTableAdapter2 = new Bessonova483_ElectroShop.Bessonova483_ElectroShopDataSetTableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(586, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 42);
            this.button2.TabIndex = 45;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoc.Location = new System.Drawing.Point(254, 19);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(190, 21);
            this.labelDoc.TabIndex = 44;
            this.labelDoc.Text = "Работа с документами";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(17, 123);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(409, 253);
            this.dataGridViewOrders.TabIndex = 46;
            this.dataGridViewOrders.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_RowEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // buttonСreate
            // 
            this.buttonСreate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСreate.Location = new System.Drawing.Point(293, 396);
            this.buttonСreate.Name = "buttonСreate";
            this.buttonСreate.Size = new System.Drawing.Size(207, 42);
            this.buttonСreate.TabIndex = 47;
            this.buttonСreate.Text = "Cоздать";
            this.buttonСreate.UseVisualStyleBackColor = true;
            this.buttonСreate.Click += new System.EventHandler(this.buttonСreate_Click);
            // 
            // labelIDOrder
            // 
            this.labelIDOrder.AutoSize = true;
            this.labelIDOrder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIDOrder.Location = new System.Drawing.Point(465, 123);
            this.labelIDOrder.Name = "labelIDOrder";
            this.labelIDOrder.Size = new System.Drawing.Size(117, 21);
            this.labelIDOrder.TabIndex = 48;
            this.labelIDOrder.Text = "Номер заказа";
            // 
            // textBoxIDorder
            // 
            this.textBoxIDorder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIDorder.Location = new System.Drawing.Point(588, 120);
            this.textBoxIDorder.Name = "textBoxIDorder";
            this.textBoxIDorder.Size = new System.Drawing.Size(100, 29);
            this.textBoxIDorder.TabIndex = 49;
            // 
            // textBoxIDClient
            // 
            this.textBoxIDClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIDClient.Location = new System.Drawing.Point(601, 180);
            this.textBoxIDClient.Name = "textBoxIDClient";
            this.textBoxIDClient.Size = new System.Drawing.Size(100, 29);
            this.textBoxIDClient.TabIndex = 51;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(465, 183);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(130, 21);
            this.labelClient.TabIndex = 50;
            this.labelClient.Text = "Номер клиента";
            // 
            // textBoxIDObject
            // 
            this.textBoxIDObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIDObject.Location = new System.Drawing.Point(588, 250);
            this.textBoxIDObject.Name = "textBoxIDObject";
            this.textBoxIDObject.Size = new System.Drawing.Size(100, 29);
            this.textBoxIDObject.TabIndex = 53;
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObject.Location = new System.Drawing.Point(465, 253);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(121, 21);
            this.labelObject.TabIndex = 52;
            this.labelObject.Text = "Номер товара";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount.Location = new System.Drawing.Point(588, 313);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 29);
            this.textBoxCount.TabIndex = 55;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(492, 316);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(66, 21);
            this.labelCount.TabIndex = 54;
            this.labelCount.Text = "Кол-во";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(588, 361);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 29);
            this.textBoxSum.TabIndex = 57;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(465, 364);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(99, 21);
            this.labelSum.TabIndex = 56;
            this.labelSum.Text = "Стоимость";
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter2
            // 
            this.ordersTableAdapter2.ClearBeforeFill = true;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // clientsTableAdapter2
            // 
            this.clientsTableAdapter2.ClearBeforeFill = true;
            // 
            // FormCreateDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxIDObject);
            this.Controls.Add(this.labelObject);
            this.Controls.Add(this.textBoxIDClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.textBoxIDorder);
            this.Controls.Add(this.labelIDOrder);
            this.Controls.Add(this.buttonСreate);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelDoc);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateDoc";
            this.Text = "Создание документа";
            this.Load += new System.EventHandler(this.FormCreateDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonСreate;
        private System.Windows.Forms.Label labelIDOrder;
        private System.Windows.Forms.TextBox textBoxIDorder;
        private System.Windows.Forms.TextBox textBoxIDClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxIDObject;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelSum;
        private Bessonova483_ElectroShopDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.OrdersTableAdapter ordersTableAdapter2;
        private Bessonova483_ElectroShopDataSethomeTableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private Bessonova483_ElectroShopDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter2;
    }
}