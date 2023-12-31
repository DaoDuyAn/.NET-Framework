namespace BlogApp
{
    partial class FormArticle
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
            labelTieuDe = new Label();
            label2 = new Label();
            label3 = new Label();
            cbbDanhMuc = new ComboBox();
            txtTieuDe = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // labelTieuDe
            // 
            labelTieuDe.AutoSize = true;
            labelTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelTieuDe.Location = new Point(286, 102);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(364, 54);
            labelTieuDe.TabIndex = 0;
            labelTieuDe.Text = "Thêm mới bài viết";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 192);
            label2.Name = "label2";
            label2.Size = new Size(144, 38);
            label2.TabIndex = 1;
            label2.Text = "Danh mục";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(100, 264);
            label3.Name = "label3";
            label3.Size = new Size(109, 38);
            label3.TabIndex = 3;
            label3.Text = "Tiêu đề";
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(286, 197);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(281, 46);
            cbbDanhMuc.TabIndex = 4;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTieuDe.Location = new Point(286, 272);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(279, 45);
            txtTieuDe.TabIndex = 5;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(557, 479);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(157, 60);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(749, 479);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(157, 60);
            btnBoQua.TabIndex = 7;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // FormArticle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBoQua;
            ClientSize = new Size(1004, 623);
            ControlBox = false;
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(txtTieuDe);
            Controls.Add(cbbDanhMuc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelTieuDe);
            Name = "FormArticle";
            Text = "FormArticle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTieuDe;
        private Label label2;
        private Label label3;
        private ComboBox cbbDanhMuc;
        private TextBox txtTieuDe;
        private Button btnDongY;
        private Button btnBoQua;
    }
}