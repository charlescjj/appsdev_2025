namespace SimpleFormsAppWithCheckedListBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            panel2 = new Panel();
            listBox1 = new ListBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 0;
            label1.Text = "FAVORITE MOVIE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(21, 49);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "PICKER APP";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(45, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 215);
            panel1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.ForeColor = Color.FromArgb(64, 64, 64);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(24, 50);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(163, 140);
            checkedListBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(60, 11);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 3;
            label3.Text = "MOVIES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(332, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 215);
            panel2.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.FromArgb(64, 64, 64);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(27, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(163, 136);
            listBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(60, 11);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 3;
            label4.Text = "FAVORITE";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(45, 348);
            button1.Name = "button1";
            button1.Size = new Size(89, 39);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(577, 111);
            button2.Name = "button2";
            button2.Size = new Size(89, 39);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(577, 173);
            button3.Name = "button3";
            button3.Size = new Size(89, 39);
            button3.TabIndex = 9;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(178, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 4, 35);
            ClientSize = new Size(714, 419);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Panel panel2;
        private Label label4;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
