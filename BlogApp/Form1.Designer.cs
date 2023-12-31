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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cbbDanhMuc = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Content = new DataGridViewTextBoxColumn();
            articleDTOBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idCategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            toolStrip1 = new ToolStrip();
            btnXoa = new ToolStripButton();
            btnThem = new ToolStripButton();
            btnSua = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)articleDTOBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(377, 142);
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
            label1.Location = new Point(401, 39);
            label1.Name = "label1";
            label1.Size = new Size(405, 60);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ BÀI VIẾT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 145);
            label2.Name = "label2";
            label2.Size = new Size(264, 38);
            label2.TabIndex = 2;
            label2.Text = "Danh mục bài viết:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Content, idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, contentDataGridViewTextBoxColumn, idCategoryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = articleDTOBindingSource;
            dataGridView1.Location = new Point(0, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1245, 516);
            dataGridView1.TabIndex = 4;
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
            // articleDTOBindingSource
            // 
            articleDTOBindingSource.DataSource = typeof(DTO.ArticleDTO);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            contentDataGridViewTextBoxColumn.HeaderText = "Content";
            contentDataGridViewTextBoxColumn.MinimumWidth = 8;
            contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            contentDataGridViewTextBoxColumn.Width = 150;
            // 
            // idCategoryDataGridViewTextBoxColumn
            // 
            idCategoryDataGridViewTextBoxColumn.DataPropertyName = "IdCategory";
            idCategoryDataGridViewTextBoxColumn.HeaderText = "IdCategory";
            idCategoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            idCategoryDataGridViewTextBoxColumn.Name = "idCategoryDataGridViewTextBoxColumn";
            idCategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbDanhMuc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 251);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(toolStrip1);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(1248, 579);
            panel2.TabIndex = 6;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnThem, btnSua, btnXoa });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1248, 34);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageTransparentColor = Color.Magenta;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(71, 29);
            btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageTransparentColor = Color.Magenta;
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(84, 29);
            btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageTransparentColor = Color.Magenta;
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(70, 29);
            btnSua.Text = "Sửa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 830);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)articleDTOBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbbDanhMuc;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private BindingSource articleDTOBindingSource;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCategoryDataGridViewTextBoxColumn;
        private Panel panel1;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnThem;
        private ToolStripButton btnSua;
        private ToolStripButton btnXoa;
    }
}