namespace BlogApp
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
            components = new System.ComponentModel.Container();
            cbbDanhMuc = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            articleDTOBindingSource = new BindingSource(components);
            Title = new DataGridViewTextBoxColumn();
            Content = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)articleDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(379, 133);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(294, 46);
            cbbDanhMuc.TabIndex = 0;
            cbbDanhMuc.SelectedIndexChanged += cbbDanhMuc_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(478, 41);
            label1.Name = "label1";
            label1.Size = new Size(405, 60);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ BÀI VIẾT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(91, 141);
            label2.Name = "label2";
            label2.Size = new Size(264, 38);
            label2.TabIndex = 2;
            label2.Text = "Danh mục bài viết:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 243);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Content });
            dataGridView1.DataSource = articleDTOBindingSource;
            dataGridView1.Location = new Point(97, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1085, 349);
            dataGridView1.TabIndex = 4;
            // 
            // articleDTOBindingSource
            // 
            articleDTOBindingSource.DataSource = typeof(DTO.ArticleDTO);
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Tiêu đề";
            Title.MinimumWidth = 8;
            Title.Name = "Title";
            Title.Width = 150;
            // 
            // Content
            // 
            Content.DataPropertyName = "Content";
            Content.HeaderText = "Nội dung";
            Content.MinimumWidth = 8;
            Content.Name = "Content";
            Content.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 706);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbDanhMuc);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)articleDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbDanhMuc;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private BindingSource articleDTOBindingSource;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Content;
    }
}