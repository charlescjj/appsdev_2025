namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] foods = { "Filipino", "Japanese", "Chinese", "Korean" };
            comboBox1.Items.AddRange(foods);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string[] filipinoFoodsList = { "Adobo", "Bulalo", "Crispy Pata", "Pancit", "Sisig" };
            string[] japaneseFoodList = { "Curry Rice", "Onigiri", "Ramen", "Sashimi", "Tonkatsu" };
            string[] chineseFoodList = { "Chow Mein", "Dim Sum", "Dumplings", "Kung Pao Chicken", "Sweet and Sour Pork" };
            string[] koreanFoodList = { "Bibimbap", "Bulgogi", "Japchae", "Samgyetang", "Tteokbokki" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(filipinoFoodsList);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox1.Items.AddRange(japaneseFoodList);
            }
            if (comboBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox1.Items.AddRange(chineseFoodList);
            }
            if (comboBox1.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox1.Items.AddRange(koreanFoodList);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
