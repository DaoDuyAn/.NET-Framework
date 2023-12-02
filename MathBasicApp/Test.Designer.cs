namespace MathBasicApp
{
    partial class Test
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
            dataGridView1 = new DataGridView();
            sinhVienBindingSource = new BindingSource(components);
            maSinhVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaySinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gioiTinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noiSinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            queQuanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hinhDaiDienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sinhVienBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maSinhVienDataGridViewTextBoxColumn, hoDataGridViewTextBoxColumn, tenDataGridViewTextBoxColumn, ngaySinhDataGridViewTextBoxColumn, gioiTinhDataGridViewTextBoxColumn, noiSinhDataGridViewTextBoxColumn, queQuanDataGridViewTextBoxColumn, hinhDaiDienDataGridViewTextBoxColumn });
            dataGridView1.DataSource = sinhVienBindingSource;
            dataGridView1.Location = new Point(42, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1360, 374);
            dataGridView1.TabIndex = 0;
            // 
            // sinhVienBindingSource
            // 
            sinhVienBindingSource.DataSource = typeof(Model.SinhVien);
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "MaSinhVien";
            maSinhVienDataGridViewTextBoxColumn.HeaderText = "MaSinhVien";
            maSinhVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            maSinhVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoDataGridViewTextBoxColumn
            // 
            hoDataGridViewTextBoxColumn.DataPropertyName = "Ho";
            hoDataGridViewTextBoxColumn.HeaderText = "Ho";
            hoDataGridViewTextBoxColumn.MinimumWidth = 8;
            hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            hoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            tenDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            tenDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            ngaySinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            gioiTinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // noiSinhDataGridViewTextBoxColumn
            // 
            noiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh";
            noiSinhDataGridViewTextBoxColumn.HeaderText = "NoiSinh";
            noiSinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            noiSinhDataGridViewTextBoxColumn.Name = "noiSinhDataGridViewTextBoxColumn";
            noiSinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            queQuanDataGridViewTextBoxColumn.HeaderText = "QueQuan";
            queQuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            queQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // hinhDaiDienDataGridViewTextBoxColumn
            // 
            hinhDaiDienDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hinhDaiDienDataGridViewTextBoxColumn.DataPropertyName = "HinhDaiDien";
            hinhDaiDienDataGridViewTextBoxColumn.HeaderText = "HinhDaiDien";
            hinhDaiDienDataGridViewTextBoxColumn.MinimumWidth = 8;
            hinhDaiDienDataGridViewTextBoxColumn.Name = "hinhDaiDienDataGridViewTextBoxColumn";
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 733);
            Controls.Add(dataGridView1);
            Name = "Test";
            Text = "Test";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sinhVienBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noiSinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hinhDaiDienDataGridViewTextBoxColumn;
        private BindingSource sinhVienBindingSource;
    }
}