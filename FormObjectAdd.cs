using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova483_ElectroShop
{
    public partial class FormObjectAdd : Form
    {
        public FormObjectAdd()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Добавление товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string nameObject = textBoxNameObject.Text;
            decimal cost = Convert.ToDecimal(textBoxCost.Text);
            int idcat = (int)comboBoxCategory.SelectedIndex;
            int idComp = (int)comboBoxCompany.SelectedIndex;
            DateTime dateMade = dateTimePickerMade.Value;
            DateTime dateResol = dateTimePickerResolution.Value;
            byte[] image = null;

            //Работа с фото
            if (pictureBoxImage.Image != null)
            {
                image = File.ReadAllBytes(openFileDialog1.FileName); //в массив
            }
            try
            {
                //Метод Insert адаптера 
                objectsTableAdapter1.Insert(nameObject, idcat, idComp, dateMade, dateResol, cost, image);
                MessageBox.Show("Товар добавлен в систему");

            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении товара");
            }
           

        }
        /// <summary>
        /// Подготовка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormObjectAdd_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = categoryTableAdapter1.GetData();
            comboBoxCategory.DisplayMember = "Title";
            comboBoxCategory.ValueMember = "ID";
            comboBoxCompany.DataSource = companyTableAdapter1.GetData();
            comboBoxCompany.DisplayMember = "Title";
            comboBoxCompany.ValueMember = "ID";

        }
        /// <summary>
        /// Загрузка изображения товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            if (buttonAddImage.Text == "Выбрать фото")
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    pictureBoxImage.Load(openFileDialog1.FileName);
                    buttonAddImage.Text = "Удалить фото";
                }
            }
            else
            {
                pictureBoxImage.Image = null;
                buttonAddImage.Text = "Выбрать фото";
            }
        }
        /// <summary>
        /// Генерация штрих-кода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowCode_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = 300,
                Height = 100,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black,
            };

            Image img = barcode.Encode(TYPE.CODE128B, "123456789");
            pictureBoxCODE128.Image = img;

        }
        /// <summary>
        /// Сохранение штрих-кода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveCode_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg|All files (*.*)|*.*";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBoxCODE128.Image.Save(sfd.FileName, format);
            }

          
           
         }
        /// <summary>
        /// Добавление компании в бд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            string compName = textBoxCompany.Text;
            categoryTableAdapter1.Insert(compName);
            FormObjectAdd_Load(null, null);
        }
    }
}

