namespace MathBasicApp
{
    partial class FormMain
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
            label1 = new Label();
            label2 = new Label();
            txtstn = new TextBox();
            txtsth = new TextBox();
            label3 = new Label();
            btncong = new Button();
            btntru = new Button();
            btnnhan = new Button();
            btnchia = new Button();
            label4 = new Label();
            rtbkq = new RichTextBox();
            linktg = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 78);
            label1.Name = "label1";
            label1.Size = new Size(994, 48);
            label1.TabIndex = 4;
            label1.Text = "TÍNH TOÁN CƠ BẢN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(119, 195);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất:";
            // 
            // txtstn
            // 
            txtstn.AccessibleName = "txtstn";
            txtstn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtstn.Location = new Point(274, 193);
            txtstn.Name = "txtstn";
            txtstn.Size = new Size(517, 31);
            txtstn.TabIndex = 0;
            // 
            // txtsth
            // 
            txtsth.AccessibleName = "txtsth";
            txtsth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtsth.Location = new Point(274, 257);
            txtsth.Name = "txtsth";
            txtsth.Size = new Size(517, 31);
            txtsth.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 257);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 3;
            label3.Text = "Số thứ hai:";
            // 
            // btncong
            // 
            btncong.BackColor = Color.IndianRed;
            btncong.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btncong.ForeColor = SystemColors.ButtonFace;
            btncong.Location = new Point(277, 337);
            btncong.Name = "btncong";
            btncong.Size = new Size(111, 57);
            btncong.TabIndex = 2;
            btncong.Tag = "+";
            btncong.Text = "Cộng";
            btncong.UseVisualStyleBackColor = false;
            btncong.Click += process_click;
            // 
            // btntru
            // 
            btntru.AccessibleName = "tx";
            btntru.BackColor = Color.FromArgb(128, 255, 128);
            btntru.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btntru.ForeColor = SystemColors.ButtonFace;
            btntru.Location = new Point(409, 337);
            btntru.Name = "btntru";
            btntru.Size = new Size(111, 57);
            btntru.TabIndex = 3;
            btntru.Tag = "-";
            btntru.Text = "Trừ";
            btntru.UseVisualStyleBackColor = false;
            btntru.Click += process_click;
            // 
            // btnnhan
            // 
            btnnhan.BackColor = Color.FromArgb(128, 128, 255);
            btnnhan.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnnhan.ForeColor = SystemColors.ButtonFace;
            btnnhan.Location = new Point(544, 337);
            btnnhan.Name = "btnnhan";
            btnnhan.Size = new Size(111, 57);
            btnnhan.TabIndex = 4;
            btnnhan.Tag = "*";
            btnnhan.Text = "Nhân";
            btnnhan.UseVisualStyleBackColor = false;
            btnnhan.Click += process_click;
            // 
            // btnchia
            // 
            btnchia.BackColor = Color.Teal;
            btnchia.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnchia.ForeColor = SystemColors.ButtonFace;
            btnchia.Location = new Point(679, 337);
            btnchia.Name = "btnchia";
            btnchia.Size = new Size(111, 57);
            btnchia.TabIndex = 5;
            btnchia.Tag = "/";
            btnchia.Text = "Chia";
            btnchia.UseVisualStyleBackColor = false;
            btnchia.Click += process_click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(119, 473);
            label4.Name = "label4";
            label4.Size = new Size(99, 30);
            label4.TabIndex = 9;
            label4.Text = "Kết quả:";
            // 
            // rtbkq
            // 
            rtbkq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbkq.BackColor = SystemColors.ControlLightLight;
            rtbkq.Location = new Point(286, 470);
            rtbkq.Name = "rtbkq";
            rtbkq.Size = new Size(505, 230);
            rtbkq.TabIndex = 10;
            rtbkq.Text = "";
            // 
            // linktg
            // 
            linktg.AccessibleDescription = "linktg";
            linktg.AccessibleName = "linktg";
            linktg.AutoSize = true;
            linktg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linktg.Location = new Point(710, 718);
            linktg.Name = "linktg";
            linktg.Size = new Size(81, 32);
            linktg.TabIndex = 11;
            linktg.TabStop = true;
            linktg.Text = "TacGia";
            linktg.LinkClicked += linktg_LinkClicked;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 759);
            Controls.Add(linktg);
            Controls.Add(rtbkq);
            Controls.Add(label4);
            Controls.Add(btnchia);
            Controls.Add(btnnhan);
            Controls.Add(btntru);
            Controls.Add(btncong);
            Controls.Add(txtsth);
            Controls.Add(label3);
            Controls.Add(txtstn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtstn;
        private TextBox txtsth;
        private Label label3;
        private Button btncong;
        private Button btntru;
        private Button btnnhan;
        private Button btnchia;
        private Label label4;
        private RichTextBox rtbkq;
        private LinkLabel linktg;
    }
}