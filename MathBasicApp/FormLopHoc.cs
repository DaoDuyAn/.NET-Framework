using MathBasicApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathBasicApp
{
    public partial class FormLopHoc : Form
    {
        public FormLopHoc()
        {
            InitializeComponent();

            NapTuFile();
        }

        void NapTuFile()
        {
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);

                lopHoc = LopHoc.FromJson(json);

                hienThiLopHoc(lopHoc);
            }
        }

        void hienThiLopHoc(LopHoc lopHoc)
        {
            txtlophoc.Text = lopHoc.TenLopHoc;
            txtphonghoc.Text = lopHoc.PhongHoc;
            txtgiangvien.Text = lopHoc.GiangVien;
            numTuTiet.Value = lopHoc.TuTiet;
            numDenTiet.Value = lopHoc.DenTiet;
            sinhVienBindingSource.DataSource = null;
            sinhVienBindingSource.DataSource = lopHoc.SinhViens;
        }


        public LopHoc lopHoc;
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            lopHoc = LopHoc.GenerateLopHoc();

            hienThiLopHoc(lopHoc);
        }

        string fileName = "LopHoc.json";
        private void btnLuuDS_Click(object sender, EventArgs e)
        {

            if (lopHoc != null)
            {
                var json = lopHoc.ToString();
                File.WriteAllText(fileName, json);

                MessageBox.Show("Lưu dữ liệu thành công", "Thông báo");
            }

        }

        private void grdSinhVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var sinhVien = sinhVienBindingSource.Current as SinhVien;

            var formSinhVien = new FormSinhVien(sinhVien);
            formSinhVien.ShowDialog();
        }

        private void btnNapFile_Click(object sender, EventArgs e)
        {
            NapTuFile();
        }

        private void grdSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuaSinhVien_Click(object sender, EventArgs e)
        {
            var sinhVien = sinhVienBindingSource.Current as SinhVien;
            var formSV = new FormSinhVien(sinhVien);
            if (formSV.ShowDialog() == DialogResult.OK)
            {
                hienThiLopHoc(lopHoc);
            }
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            var formSV = new FormSinhVien(null);
            if (formSV.ShowDialog() == DialogResult.OK)
            {
                lopHoc.SinhViens.Add(formSV.sinhVien);
                hienThiLopHoc(lopHoc);
            }
        }

        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            var sinhVien = sinhVienBindingSource.Current as SinhVien;
            if (sinhVien != null)
            {
                lopHoc.SinhViens.Remove(sinhVien);
                hienThiLopHoc(lopHoc);
            }
        }
    }
}
