using MathBasicApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathBasicApp
{
    public partial class FormSinhVien : Form
    {

        public FormSinhVien()
        {
            InitializeComponent();
            LoadSinhVien();
        }

        void LoadSinhVien()
        {
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                var sinhVien = SinhVien.FromJson(json);

                txtmsv.Text = sinhVien.MaSinhVien;
                txtho.Text = sinhVien.Ho;
                txtten.Text = sinhVien.Ten;
                txtns.Text = sinhVien.NoiSinh;
                txtqq.Text = sinhVien.QueQuan;
                dtp.Value = sinhVien.NgaySinh;
                cbbgt.SelectedIndex = (int)sinhVien.GioiTinh;
                picHinhDaiDien.ImageLocation = sinhVien.HinhDaiDien;
            }

        }

        string fileName = "sinhvien.json";

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var sinhVien = new SinhVien
            {
                MaSinhVien = txtmsv.Text,
                Ho = txtho.Text,
                Ten = txtten.Text,
                NgaySinh = dtp.Value,
                GioiTinh = (GIOITINH)cbbgt.SelectedIndex,
                QueQuan = txtqq.Text,
                NoiSinh = txtns.Text,
                HinhDaiDien = picHinhDaiDien.ImageLocation,
            };

            var json = sinhVien.ToString();
            File.WriteAllText(fileName, json);
            MessageBox.Show("Bạn đã lưu dữ liệu thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picHinhDaiDien_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Title = "Chọn file ảnh"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFile.FileName;
                picHinhDaiDien.ImageLocation = selectedFile;
            }
        }
    }
}
