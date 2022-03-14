using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova483_ElectroShop
{
    public partial class FormObjects : Form
    {
        List<ListViewItem> masterlist;
        public FormObjects()
        {
            InitializeComponent();
            masterlist = new List<ListViewItem>();
        }
        Bessonova483_ElectroShopDataSet.ObjectsDataTable objects;
        Bessonova483_ElectroShopDataSet.CategoryDataTable categories;
        
        /// <summary>
        /// Назад в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Вторая фильтрация
        /// </summary>
        /// <param name="searchcat"></param>
        private void ShowObjectsincategory(int searchcat)
        {
            //Получить все данные из таблицы БД Service
            objects = objectsTableAdapter1.GetData();
            //Вспомогательные величины
            int i = 0;
           
            string filePath;
            //Настроить список элементов и картинок
            this.listViewObjects.Items.Clear();		//Очистить список
            this.imageListObject.Images.Clear();
            // Вывод числа записей
            int countRecord = objects.Count;		//Всех записей
            //Фильтр записей по интервалу скидок и по заголовку
            var filter = objects.Where(x => x.IDCategory == searchcat);
            //Список записей фильтра
            var listFilter = filter.ToList();
            int countFilter = listFilter.Count();	//Количество отфильтрованный записей
            //Отображение отфильтрованных записей в ListView
            i = 0;						//Индекс для картинок
            //Просмотр все отфильтрованных записей
            foreach (var item in listFilter)
            {
                ListViewItem lvi = new ListViewItem();	//Отдельный элемент списка
                
                //Заполнения массива изображений
                filePath = @"F:\Загрузки\Electroshop\Ресурсы\ObjectsImage" + @"\" + item.ImageObject;	//Путь к изображению
                if (File.Exists(filePath))			//Проверка наличия изображения
                {
                    this.imageListObject.Images.Add(Image.FromFile(filePath)); 	//Есть
                }
                else
                {
                    this.imageListObject.Images.Add(Properties.Resources.noimg);	//Нет
                }
                //Заголовок элемента списка
                lvi.Text = item.Title + Environment.NewLine + item.Cost;	//Заголовок+цена
                lvi.ImageIndex = i;			//Номер изображения из массива картинок
                listViewObjects.Items.Add(lvi);	//Добавить созданный элемент в список
                i++;					//Следующий номер картинки
            }
        }
        /// <summary>
        /// Фильтрация по комбобоксу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int searchcat = comboBoxCategory.SelectedIndex ;		//Индекс элемента в списке

            ShowObjectsincategory(searchcat);		//Метод фильтрации и отображения
        }
        /// <summary>
        /// Первая фильтрация
        /// </summary>
        private void DisplayItems()
        {
            listViewObjects.Items.Clear();

            // This filters and adds your filtered items to listView1
            foreach (ListViewItem item in masterlist.Where(lvi => lvi.Text.ToLower().Contains(textBoxSearch.Text.ToLower().Trim())))
            {
                listViewObjects.Items.Add(item);
            }
        }
        /// <summary>
        /// Фильтр по текстбоксу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DisplayItems();

        }
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormObjects_Load(object sender, EventArgs e)
        {
            categories = categoryTableAdapter1.GetData();
            //Настроить список
            this.listViewObjects.CheckBoxes = true;	//Будут флажки для элементов
            this.listViewObjects.LabelWrap = true;	//С переносом
            this.listViewObjects.MultiSelect = true;	//Можно выделять несколько элементов
            this.listViewObjects.FullRowSelect = true;	//Выделять все при выборе элемента
            this.listViewObjects.RightToLeftLayout = false;	//Слева направо
            this.listViewObjects.Scrollable = true;	//Полосы прокрутки
            //Разновидность списка - Большие картинки
            this.listViewObjects.View = View.LargeIcon;
            //Связь список с массивом картинок
            this.listViewObjects.LargeImageList = imageListObject;
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Title";
            comboBoxCategory.ValueMember = "ID";
            comboBoxCategory.SelectedIndex = 0;			//Изначально - все
            comboBoxCategory_SelectedIndexChanged(null, null);	//Получить параметры фильтрации
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormOrders orders = new FormOrders();
            this.Hide();
            orders.Show();
            this.ShowDialog();
        }
    }
}
