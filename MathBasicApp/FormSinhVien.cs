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

        public FormSinhVien(SinhVien sinhVien)
        {
            InitializeComponent();

            this.sinhVien = sinhVien;
            if (sinhVien != null)
            {
                txtmsv.Text = sinhVien.MaSinhVien;
                txtho.Text = sinhVien.Ho;
                txtten.Text = sinhVien.Ten;
                txtns.Text = sinhVien.NoiSinh;
                txtqq.Text = sinhVien.QueQuan;
                dtpns.Value = sinhVien.NgaySinh;
                cbbgt.SelectedIndex = (int)sinhVien.GioiTinh;
                picHinhDaiDien.ImageLocation = sinhVien.HinhDaiDien;
            }

            //LoadSinhVienTuFile();
        }

        void LoadSinhVienTuFile()
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
                dtpns.Value = sinhVien.NgaySinh;
                cbbgt.SelectedIndex = (int)sinhVien.GioiTinh;
                picHinhDaiDien.ImageLocation = sinhVien.HinhDaiDien;
            }

        }

        string fileName = "sinhvien.json";
        public SinhVien sinhVien { set; get; }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (sinhVien != null)
            {
                // Thêm mới
                sinhVien.Ho = txtho.Text;
                sinhVien.Ten = txtten.Text;
                sinhVien.NoiSinh = txtns.Text;
                sinhVien.QueQuan = txtqq.Text;
                sinhVien.MaSinhVien = txtmsv.Text;
                sinhVien.HinhDaiDien = picHinhDaiDien.ImageLocation;
                sinhVien.NgaySinh = dtpns.Value;
                sinhVien.GioiTinh = (GIOITINH)cbbgt.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
            else
            {
                // Cập nhật
                sinhVien = new SinhVien();
                sinhVien.Ho = txtho.Text;
                sinhVien.Ten = txtten.Text;
                sinhVien.NoiSinh = txtns.Text;
                sinhVien.QueQuan = txtqq.Text;
                sinhVien.MaSinhVien = txtmsv.Text;
                sinhVien.HinhDaiDien = picHinhDaiDien.ImageLocation;
                sinhVien.NgaySinh = dtpns.Value;
                sinhVien.GioiTinh = (GIOITINH)cbbgt.SelectedIndex;
                DialogResult = DialogResult.OK;
            }



            /*  sinhVien = new SinhVien
              {
                  MaSinhVien = txtmsv.Text,
                  Ho = txtho.Text,
                  Ten = txtten.Text,
                  NgaySinh = dtp.Value,
                  GioiTinh = (GIOITINH)cbbgt.SelectedIndex,
                  QueQuan = txtqq.Text,
                  NoiSinh = txtns.Text,
                  HinhDaiDien = picHinhDaiDien.ImageLocation,
              };*/
            /*
                        var json = sinhVien.ToString();
                        File.WriteAllText(fileName, json);
                        MessageBox.Show("Bạn đã lưu dữ liệu thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);*/
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
