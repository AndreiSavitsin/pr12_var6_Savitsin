namespace pr12_var6_Savitsin
{
    public partial class Form1 : Form
    {
        private List<Buyer> buyers; //Массив покупателей
        private Buyer currentBuyer; //Текущий выбранный покупатель
        public Form1()
        {
            InitializeComponent();
            CreateBuyersArray();    // создаем массив из 10 объектов
            ShowInDataGrid();        // выводим в DataGridView
        }
        //Создание массива из 10 элементов
        private void CreateBuyersArray()
        {
            buyers = new List<Buyer>();

            //Названия продуктов
            string[] products = { "Молоко", "Хлеб", "Яйца", "Сыр", "Мясо", "Рыба", "Сок", "Йогурт", "Печенье", "Шоколад" };

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                string name = products[i];
                double price = rnd.Next(50, 500);
                int count = rnd.Next(1, 6);
                double wallet = rnd.Next(300, 2000);

                buyers.Add(new Buyer(name, price, count, wallet));
            }
        }
        //Вывод в DataGridView
        private void ShowInDataGrid()
        {
            //Очищаем
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            //Создаем колонки
            dataGridView1.Columns.Add("colProduct", "Продукт");
            dataGridView1.Columns.Add("colPrice", "Цена");
            dataGridView1.Columns.Add("colCount", "Количество");
            dataGridView1.Columns.Add("colWallet", "Кошелёк");
            dataGridView1.Columns.Add("colMood", "Настроение");
            dataGridView1.Columns.Add("colMoodStatus", "Состояние");

            //Заполняем строки
            foreach (Buyer buyer in buyers)
            {
                dataGridView1.Rows.Add(buyer.GetName(), buyer.GetPrice(), buyer.GetCount(), buyer.GetWallet(), buyer.GetMood(), buyer.GetMoodStatus());
            }

            //Настройка ширины колонок
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Получить выбранного покупателя
        private Buyer GetSelectedBuyer()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0 && index < buyers.Count)
                    return buyers[index];
            }
            return null;
        }
        //Кнопка купить
        private void btnBuy_Click(object sender, EventArgs e)
        {
            Buyer selected = GetSelectedBuyer();
            if (selected == null)
            {
                MessageBox.Show("Выберите покупателя в таблице!");
                return;
            }

            string result = selected.Buy();
            MessageBox.Show(result, "Результат покупки");
            ShowInDataGrid(); // обновляем таблицу
        }
        //Кнопка информация
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Buyer selected = GetSelectedBuyer();
            if (selected == null)
            {
                MessageBox.Show("Выберите покупателя в таблице!");
                return;
            }

            MessageBox.Show(selected.GetBuyInfo(), "Информация о покупке");
        }
        //Кнопка настроение
        private void btnMood_Click(object sender, EventArgs e)
        {
            Buyer selected = GetSelectedBuyer();
            if (selected == null)
            {
                MessageBox.Show("Выберите покупателя в таблице!");
                return;
            }

            string status = selected.GetMoodStatus();
            MessageBox.Show($"Настроение: {status} (значение: {selected.GetMood()})", "Состояние настроения");
        }
    }
}
