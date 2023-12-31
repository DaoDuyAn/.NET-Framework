namespace BlogApp
{
    partial class FormThem
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
            txtDanhMuc = new TextBox();
            btndongy = new Button();
            btnboqua = new Button();
            SuspendLayout();
            // 
            // labelTieuDe
            // 
            labelTieuDe.AutoSize = true;
            labelTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTieuDe.Location = new Point(229, 81);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(181, 48);
            labelTieuDe.TabIndex = 0;
            labelTieuDe.Text = "Thêm mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 156);
            label2.Name = "label2";
            label2.Size = new Size(150, 38);
            label2.TabIndex = 1;
            label2.Text = "Danh mục:";
            // 
            // txtDanhMuc
            // 
            txtDanhMuc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDanhMuc.Location = new Point(229, 156);
            txtDanhMuc.Name = "txtDanhMuc";
            txtDanhMuc.Size = new Size(208, 45);
            txtDanhMuc.TabIndex = 2;
            // 
            // btndongy
            // 
            btndongy.Location = new Point(538, 323);
            btndongy.Name = "btndongy";
            btndongy.Size = new Size(110, 52);
            btndongy.TabIndex = 3;
            btndongy.Text = "Đồng ý";
            btndongy.UseVisualStyleBackColor = true;
            btndongy.Click += btndongy_Click;
            // 
            // btnboqua
            // 
            btnboqua.Location = new Point(713, 323);
            btnboqua.Name = "btnboqua";
            btnboqua.Size = new Size(110, 52);
            btnboqua.TabIndex = 4;
            btnboqua.Text = "Bỏ qua";
            btnboqua.UseVisualStyleBackColor = true;
            // 
            // FormThem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnboqua;
            ClientSize = new Size(865, 446);
            ControlBox = false;
            Controls.Add(btnboqua);
            Controls.Add(btndongy);
            Controls.Add(txtDanhMuc);
            Controls.Add(label2);
            Controls.Add(labelTieuDe);
            Name = "FormThem";
            Text = "FormThem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTieuDe;
        private Label label2;
        private TextBox txtDanhMuc;
        private Button btndongy;
        private Button btnboqua;
    }
}