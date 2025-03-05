namespace SimpleFormsAppWithMessageBoxes
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
            fname = new TextBox();
            initial = new TextBox();
            lname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            suffix = new TextBox();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(296, 32);
            label1.TabIndex = 0;
            label1.Text = "Simple Form Application";
            label1.Click += label1_Click;
            // 
            // fname
            // 
            fname.Location = new Point(68, 119);
            fname.Name = "fname";
            fname.Size = new Size(187, 23);
            fname.TabIndex = 1;
            // 
            // initial
            // 
            initial.Location = new Point(68, 193);
            initial.Name = "initial";
            initial.Size = new Size(187, 23);
            initial.TabIndex = 2;
            initial.TextChanged += textBox2_TextChanged;
            // 
            // lname
            // 
            lname.Location = new Point(69, 262);
            lname.Name = "lname";
            lname.Size = new Size(187, 23);
            lname.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 101);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(68, 175);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 6;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(69, 244);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 7;
            label4.Text = "Last Name";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(177, 329);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 166);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // suffix
            // 
            suffix.Location = new Point(68, 329);
            suffix.Name = "suffix";
            suffix.Size = new Size(187, 23);
            suffix.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(69, 311);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 12;
            label5.Text = "Suffix";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(122, 403);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 13;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 488);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(suffix);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lname);
            Controls.Add(initial);
            Controls.Add(fname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fname;
        private TextBox initial;
        private TextBox lname;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox suffix;
        private Label label5;
        private Button button1;
    }
}
