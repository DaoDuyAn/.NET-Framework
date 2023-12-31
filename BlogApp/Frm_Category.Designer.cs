namespace BlogApp
{
    partial class Frm_Category
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Category));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountArticlesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnXoa = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            btnSua = new ToolStripButton();
            btnThem = new ToolStripButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(338, 24);
            label1.Name = "label1";
            label1.Size = new Size(516, 65);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ DANH MỤC";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 103);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(toolStrip1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 628);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, amountArticlesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = categoryDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1179, 581);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Tên danh mục";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountArticlesDataGridViewTextBoxColumn
            // 
            amountArticlesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amountArticlesDataGridViewTextBoxColumn.DataPropertyName = "AmountArticles";
            amountArticlesDataGridViewTextBoxColumn.HeaderText = "Số lượng bài viết";
            amountArticlesDataGridViewTextBoxColumn.MinimumWidth = 8;
            amountArticlesDataGridViewTextBoxColumn.Name = "amountArticlesDataGridViewTextBoxColumn";
            amountArticlesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDTOBindingSource
            // 
            categoryDTOBindingSource.DataSource = typeof(DTO.CategoryDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnXoa, toolStripButton2, btnSua, btnThem });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1179, 47);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnXoa
            // 
            btnXoa.Alignment = ToolStripItemAlignment.Right;
            btnXoa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageTransparentColor = Color.Magenta;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 42);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(281, 42);
            toolStripButton2.Text = "Danh sách danh mục";
            // 
            // btnSua
            // 
            btnSua.Alignment = ToolStripItemAlignment.Right;
            btnSua.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageTransparentColor = Color.Magenta;
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 42);
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Alignment = ToolStripItemAlignment.Right;
            btnThem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageTransparentColor = Color.Magenta;
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 42);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // Frm_Category
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 731);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_Category";
            Text = "Frm_Category";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnXoa;
        private ToolStripButton toolStripButton2;
        private ToolStripButton btnSua;
        private ToolStripButton btnThem;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountArticlesDataGridViewTextBoxColumn;
        private BindingSource categoryDTOBindingSource;
    }
}