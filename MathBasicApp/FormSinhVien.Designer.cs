namespace MathBasicApp
{
    partial class FormSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtmsv = new TextBox();
            txtho = new TextBox();
            label3 = new Label();
            txtten = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtp = new DateTimePicker();
            label6 = new Label();
            cbbgt = new ComboBox();
            txtns = new TextBox();
            label7 = new Label();
            txtqq = new TextBox();
            label8 = new Label();
            btnDongY = new Button();
            btnBoQua = new Button();
            label9 = new Label();
            label10 = new Label();
            picHinhDaiDien = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picHinhDaiDien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 255);
            label1.Location = new Point(351, 78);
            label1.Name = "label1";
            label1.Size = new Size(409, 48);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(133, 175);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 1;
            label2.Text = "Mã sinh viên:";
            // 
            // txtmsv
            // 
            txtmsv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtmsv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmsv.Location = new Point(314, 175);
            txtmsv.Name = "txtmsv";
            txtmsv.Size = new Size(723, 39);
            txtmsv.TabIndex = 0;
            // 
            // txtho
            // 
            txtho.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtho.Location = new Point(314, 242);
            txtho.Name = "txtho";
            txtho.Size = new Size(300, 39);
            txtho.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(133, 240);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 3;
            label3.Text = "Họ:";
            // 
            // txtten
            // 
            txtten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtten.Location = new Point(748, 242);
            txtten.Name = "txtten";
            txtten.Size = new Size(290, 39);
            txtten.TabIndex = 2;
            txtten.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(669, 249);
            label4.Name = "label4";
            label4.Size = new Size(61, 32);
            label4.TabIndex = 5;
            label4.Text = "Tên:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(133, 300);
            label5.Name = "label5";
            label5.Size = new Size(135, 32);
            label5.TabIndex = 7;
            label5.Text = "Ngày sinh:";
            // 
            // dtp
            // 
            dtp.CustomFormat = "dd/MM/yyyy";
            dtp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Location = new Point(314, 305);
            dtp.Name = "dtp";
            dtp.Size = new Size(301, 39);
            dtp.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(620, 308);
            label6.Name = "label6";
            label6.Size = new Size(119, 32);
            label6.TabIndex = 9;
            label6.Text = "Giới tính:";
            // 
            // cbbgt
            // 
            cbbgt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbgt.FormattingEnabled = true;
            cbbgt.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbbgt.Location = new Point(748, 300);
            cbbgt.Name = "cbbgt";
            cbbgt.Size = new Size(290, 40);
            cbbgt.TabIndex = 4;
            // 
            // txtns
            // 
            txtns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtns.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtns.Location = new Point(314, 360);
            txtns.Name = "txtns";
            txtns.Size = new Size(724, 39);
            txtns.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(133, 360);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 11;
            label7.Text = "Nơi sinh:";
            // 
            // txtqq
            // 
            txtqq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtqq.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtqq.Location = new Point(314, 419);
            txtqq.Name = "txtqq";
            txtqq.Size = new Size(724, 39);
            txtqq.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(133, 419);
            label8.Name = "label8";
            label8.Size = new Size(132, 32);
            label8.TabIndex = 13;
            label8.Text = "Quê quán:";
            // 
            // btnDongY
            // 
            btnDongY.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDongY.BackColor = Color.CornflowerBlue;
            btnDongY.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDongY.ForeColor = SystemColors.ButtonHighlight;
            btnDongY.Location = new Point(729, 754);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(142, 53);
            btnDongY.TabIndex = 15;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = false;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBoQua.BackColor = Color.White;
            btnBoQua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoQua.Location = new Point(904, 754);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(134, 53);
            btnBoQua.TabIndex = 16;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(138, 689);
            label9.Name = "label9";
            label9.Size = new Size(900, 3);
            label9.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(133, 489);
            label10.Name = "label10";
            label10.Size = new Size(174, 32);
            label10.TabIndex = 18;
            label10.Text = "Hình đại diện:";
            // 
            // picHinhDaiDien
            // 
            picHinhDaiDien.Location = new Point(314, 489);
            picHinhDaiDien.Name = "picHinhDaiDien";
            picHinhDaiDien.Size = new Size(259, 126);
            picHinhDaiDien.TabIndex = 19;
            picHinhDaiDien.TabStop = false;
            picHinhDaiDien.Click += picHinhDaiDien_Click;
            // 
            // FormSinhVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 849);
            Controls.Add(picHinhDaiDien);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(txtqq);
            Controls.Add(label8);
            Controls.Add(txtns);
            Controls.Add(label7);
            Controls.Add(cbbgt);
            Controls.Add(label6);
            Controls.Add(dtp);
            Controls.Add(label5);
            Controls.Add(txtten);
            Controls.Add(label4);
            Controls.Add(txtho);
            Controls.Add(label3);
            Controls.Add(txtmsv);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSinhVien";
            Text = "FormSinhVien";
            Load += FormSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)picHinhDaiDien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtmsv;
        private TextBox txtho;
        private Label label3;
        private TextBox txtten;
        private Label label4;
        private Label label5;
        private DateTimePicker dtp;
        private Label label6;
        private ComboBox cbbgt;
        private TextBox txtns;
        private Label label7;
        private TextBox txtqq;
        private Label label8;
        private Button btnDongY;
        private Button btnBoQua;
        private Label label9;
        private Label label10;
        private PictureBox picHinhDaiDien;
    }
}