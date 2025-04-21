namespace SimpleIPhoneLoanCalculator
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
            panel1 = new Panel();
            modelListBox = new ListBox();
            label3 = new Label();
            panel2 = new Panel();
            addOnsCheckedList = new CheckedListBox();
            label4 = new Label();
            panel3 = new Panel();
            loanTermcomboBox = new ComboBox();
            label5 = new Label();
            calculationTextBox = new TextBox();
            calcBtn = new Button();
            resetBtn = new Button();
            label2 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(222, 32);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE LOAN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(modelListBox);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(56, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 237);
            panel1.TabIndex = 2;
            // 
            // modelListBox
            // 
            modelListBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modelListBox.ForeColor = Color.FromArgb(64, 64, 64);
            modelListBox.FormattingEnabled = true;
            modelListBox.ItemHeight = 20;
            modelListBox.Location = new Point(34, 68);
            modelListBox.Name = "modelListBox";
            modelListBox.Size = new Size(198, 144);
            modelListBox.TabIndex = 3;
            modelListBox.SelectedIndexChanged += modelListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 20);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 3;
            label3.Text = "MODEL";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(addOnsCheckedList);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(56, 405);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 237);
            panel2.TabIndex = 4;
            // 
            // addOnsCheckedList
            // 
            addOnsCheckedList.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOnsCheckedList.ForeColor = Color.FromArgb(64, 64, 64);
            addOnsCheckedList.FormattingEnabled = true;
            addOnsCheckedList.Location = new Point(34, 68);
            addOnsCheckedList.Name = "addOnsCheckedList";
            addOnsCheckedList.Size = new Size(198, 136);
            addOnsCheckedList.TabIndex = 4;
            addOnsCheckedList.SelectedIndexChanged += addOnsCheckedList_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 20);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 3;
            label4.Text = "ADD ONS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(loanTermcomboBox);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(397, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 134);
            panel3.TabIndex = 5;
            // 
            // loanTermcomboBox
            // 
            loanTermcomboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loanTermcomboBox.ForeColor = Color.FromArgb(64, 64, 64);
            loanTermcomboBox.FormattingEnabled = true;
            loanTermcomboBox.Location = new Point(29, 68);
            loanTermcomboBox.Name = "loanTermcomboBox";
            loanTermcomboBox.Size = new Size(141, 28);
            loanTermcomboBox.TabIndex = 4;
            loanTermcomboBox.SelectedIndexChanged += loanTermcomboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 20);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 3;
            label5.Text = "LOAN TERM";
            // 
            // calculationTextBox
            // 
            calculationTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculationTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            calculationTextBox.Location = new Point(397, 337);
            calculationTextBox.Multiline = true;
            calculationTextBox.Name = "calculationTextBox";
            calculationTextBox.Size = new Size(382, 308);
            calculationTextBox.TabIndex = 6;
            // 
            // calcBtn
            // 
            calcBtn.BackColor = Color.Black;
            calcBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            calcBtn.ForeColor = Color.White;
            calcBtn.Location = new Point(658, 139);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(112, 43);
            calcBtn.TabIndex = 7;
            calcBtn.Text = "Calculate";
            calcBtn.UseVisualStyleBackColor = false;
            calcBtn.Click += calcBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Black;
            resetBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(658, 199);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(112, 43);
            resetBtn.TabIndex = 8;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label2.Location = new Point(34, 70);
            label2.Name = "label2";
            label2.Size = new Size(284, 32);
            label2.TabIndex = 9;
            label2.Text = "CALCULATOR APP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(397, 311);
            label6.Name = "label6";
            label6.Size = new Size(146, 23);
            label6.TabIndex = 5;
            label6.Text = "Cost Breakdown:";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(713, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 121);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(850, 692);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(resetBtn);
            Controls.Add(panel2);
            Controls.Add(calcBtn);
            Controls.Add(calculationTextBox);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ListBox modelListBox;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private CheckedListBox addOnsCheckedList;
        private Panel panel3;
        private ComboBox loanTermcomboBox;
        private Label label5;
        private TextBox calculationTextBox;
        private Button calcBtn;
        private Button resetBtn;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
