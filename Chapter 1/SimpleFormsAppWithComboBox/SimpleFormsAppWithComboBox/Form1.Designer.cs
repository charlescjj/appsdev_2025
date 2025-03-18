namespace SimpleFormsAppWithComboBox
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            panel3 = new Panel();
            listBox1 = new ListBox();
            label5 = new Label();
            selectBtn = new Button();
            addBtn = new Button();
            deleteBtn = new Button();
            clearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 0;
            label1.Text = "FAVORITE FOOD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(40, 62);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 1;
            label2.Text = "PICKER APP";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(232, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 114);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(60, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 116);
            panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 28);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(62, 21);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 4;
            label3.Text = "CUISINE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(314, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 220);
            panel2.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.ForeColor = Color.FromArgb(64, 64, 64);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(32, 56);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(162, 124);
            checkedListBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(69, 21);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 5;
            label4.Text = "FOOD LIST";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Controls.Add(listBox1);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(597, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 220);
            panel3.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.FromArgb(64, 64, 64);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(36, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 130);
            listBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(32, 21);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 5;
            label5.Text = "FAVORITE FOOD LIST";
            // 
            // selectBtn
            // 
            selectBtn.BackColor = Color.White;
            selectBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectBtn.Location = new Point(120, 294);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(75, 36);
            selectBtn.TabIndex = 8;
            selectBtn.Text = "Select";
            selectBtn.UseVisualStyleBackColor = false;
            selectBtn.Click += selectBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.White;
            addBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            addBtn.Location = new Point(467, 401);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 34);
            addBtn.TabIndex = 9;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.White;
            deleteBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            deleteBtn.Location = new Point(586, 401);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 34);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.White;
            clearBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            clearBtn.Location = new Point(691, 401);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 34);
            clearBtn.TabIndex = 11;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 26, 20);
            ClientSize = new Size(894, 482);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(selectBtn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel2;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private ListBox listBox1;
        private Button selectBtn;
        private Button addBtn;
        private Button deleteBtn;
        private Button clearBtn;
    }
}
