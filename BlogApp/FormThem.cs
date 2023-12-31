using BlogApp.DTO;
using BlogApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogApp
{
    public partial class FormThem : Form
    {
        CategoryDTO category;
        public FormThem(CategoryDTO category = null)
        {
            InitializeComponent();
            this.category = category;
            if (category != null)
            {
                // Cập nhật
                this.Text = "Cập nhật danh mục";
                labelTieuDe.Text = "Cập nhật";
                txtDanhMuc.Text = category.Name;
            }
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                // Thêm mới
                var obj = new Category
                {
                    Name = txtDanhMuc.Text,
                };

                var db = new BlogDB();
                db.Categories.Add(obj);
                db.SaveChanges();

                DialogResult = DialogResult.OK;
            }
            else
            {
                // Cập nhật
                var db = new BlogDB();

                var obj = db.Categories.Where(t => t.Id == category.Id).FirstOrDefault();
                if (obj != null)
                {
                    obj.Name = txtDanhMuc.Text;
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }


            }
        }
    }
}
