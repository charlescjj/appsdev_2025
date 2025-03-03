namespace SimpleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string fnameValue = textBox1.Text;
            string lnameValue = textBox2.Text;

            MessageBox.Show($"Hello There! {fnameValue} {lnameValue}!", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
