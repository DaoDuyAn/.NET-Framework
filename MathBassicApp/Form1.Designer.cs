namespace MathBassicApp
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

        private Button GetButton1()
        {
            return button1;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button button1)
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 46);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TOÁN CƠ BẢN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 108);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất:";
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "txtstn";
            textBox1.Location = new Point(258, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "txtsth";
            textBox2.Location = new Point(258, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(506, 31);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 160);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 3;
            label3.Text = "Số thứ hai:";
            // 
            // button1
            // 
            button1.AccessibleDescription = "btnc";
            button1.AccessibleName = "btnc";
            button1.Location = new Point(256, 227);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Cộng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "btnt";
            button2.Location = new Point(388, 227);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Trừ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AccessibleName = "btnn";
            button3.Location = new Point(518, 227);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "Nhân";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AccessibleName = "btnc";
            button4.Location = new Point(652, 227);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 8;
            button4.Text = "Chia";
            button4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.AccessibleName = "ctbkq";
            richTextBox1.Location = new Point(258, 309);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(506, 144);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 337);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 10;
            label4.Text = "Kết quả:";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 525);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private RichTextBox richTextBox1;
        private Label label4;
    }
}