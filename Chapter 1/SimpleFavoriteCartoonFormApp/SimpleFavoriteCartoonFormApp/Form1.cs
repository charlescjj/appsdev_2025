using Microsoft.VisualBasic.ApplicationServices;

namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] characters = { "Mickey", "Finn", "Robin", "Bubbles", "Kuromi" };
            comboBox1.Items.AddRange(characters);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            switch (selectedCharacter)
            {
                case "Mickey":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\mickey.jpg");
                    break;
                case "Finn":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\finn.jpg");
                    break;
                case "Robin":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\robin.jpg");
                    break;
                case "Bubbles":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\bubbles.jpg");
                    break;
                case "Kuromi":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\kuromi.jpg");
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
