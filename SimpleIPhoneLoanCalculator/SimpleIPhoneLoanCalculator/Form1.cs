namespace SimpleIPhoneLoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void modelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addOnsCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loanTermcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {

            if (modelListBox.SelectedItem == null || loanTermcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an iPhone model and a loan term.");
                return;
            }

            string selectedModel = modelListBox.SelectedItem.ToString();
            double principalAmount = GetIphonePrice(selectedModel);

            string selectedLoanTerm = loanTermcomboBox.SelectedItem.ToString();
            int loanTerm = int.Parse(new string(selectedLoanTerm.Where(char.IsDigit).ToArray()));

            double interestRate = GetInterestRate(loanTerm);
            double downPayment = principalAmount * 0.10;

            double addOnsCost = 0;
            foreach (object item in addOnsCheckedList.CheckedItems)
            {
                addOnsCost += GetAccessoryPrice(item.ToString());
            }

            double totalPrincipal = principalAmount + addOnsCost;
            double interestAmount = totalPrincipal * interestRate;
            double totalAmount = totalPrincipal + interestAmount;
            double monthlyAmortization = totalAmount / loanTerm;

            calculationTextBox.Text = $"\r\nModel: {selectedModel}\r\n" +
                $"Principal Amount: Php {principalAmount:N2}\r\n" +
                $"Down Payment: Php {downPayment:N2}\r\n" +
                $"Loan Term: {loanTerm} Months\r\n" +
                $"Interest Rate: {interestRate * 100}%\r\n" +
                $"Interest Amount: Php {interestAmount:N2}\r\n" +
                $"Total Monthly Amortization: Php {monthlyAmortization:N2}\r\n" +
                $"Total Loan Amount: Php {totalAmount:N2}";

        }
        private double GetIphonePrice(string model)
        {
            if (model == "iPhone 16 Pro Max (256GB)") return 69990;
            if (model == "iPhone 16 Pro (128GB)") return 84990;
            if (model == "iPhone 16 Plus (128GB)") return 54990;
            if (model == "iPhone 16 (128GB)") return 62990;
            if (model == "iPhone 16e (128GB)") return 39990;
            return 0;
        }

        private double GetAccessoryPrice(string accessory)
        {
            if (accessory == "Apple Care Plus") return 2590;
            if (accessory == "USB-C Charging Adapter") return 1990;
            if (accessory == "MagSafe Charger (1M)") return 2490;
            return 0;
        }

        private double GetInterestRate(int term)
        {
            if (term == 12) return 0.05;
            if (term == 24) return 0.10;
            if (term == 30) return 0.125;
            if (term == 36) return 0.15;
            return 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            modelListBox.Items.Clear();
            modelListBox.Items.Add("iPhone 16 Pro Max (256GB)");
            modelListBox.Items.Add("iPhone 16 Pro (128GB)");
            modelListBox.Items.Add("iPhone 16 Plus (128GB)");
            modelListBox.Items.Add("iPhone 16 (128GB)");
            modelListBox.Items.Add("iPhone 16e (128GB)");

            addOnsCheckedList.Items.Clear();
            addOnsCheckedList.Items.Add("Apple Care Plus");
            addOnsCheckedList.Items.Add("USB-C Charging Adapter");
            addOnsCheckedList.Items.Add("MagSafe Charger (1M)");

            loanTermcomboBox.Items.Clear();
            loanTermcomboBox.Items.Add("12 Months");
            loanTermcomboBox.Items.Add("24 Months");
            loanTermcomboBox.Items.Add("30 Months");
            loanTermcomboBox.Items.Add("36 Months");
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            modelListBox.ClearSelected();
            loanTermcomboBox.SelectedIndex = -1;

            for (int i = 0; i < addOnsCheckedList.Items.Count; i++)
            {
                addOnsCheckedList.SetItemChecked(i, false);
            }

            calculationTextBox.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

