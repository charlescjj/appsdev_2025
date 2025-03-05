namespace SimpleFormsAppWithMessageBoxes
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fnamevalue = fname.Text;
            string mnamevalue = initial.Text;
            string lnamevalue = lname.Text;
            string snamevalue = suffix.Text;

            DialogResult confirmationResult = MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmationResult == DialogResult.Yes)
            {

                string greetingMessage = $"Hello There! {fnamevalue} {mnamevalue} {lnamevalue} {snamevalue}!";
                MessageBox.Show(greetingMessage, "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Submission canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
        

