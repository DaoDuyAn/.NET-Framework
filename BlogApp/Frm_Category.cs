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
    public partial class Frm_Category : Form
    {
        public Frm_Category()
        {
            InitializeComponent();
            LoadCategory();
        }

        void LoadCategory()
        {
            // Đổ dữ liệu danh mục lên combobox

            // B1: Lấy dữ liệu danh mục từ DB
            var db = new BlogDB();
            /*List<Category> ls = db.Categories.OrderByDescending(c => c.Name).ToList();*/

            List<CategoryDTO> ls = db.Categories
                //.Where(c => c.Name.StartsWith("T"))
                .OrderBy(c => c.Name)
                .Select(e => new CategoryDTO
                {
                    Id = e.Id,
                    Name = e.Name,
                    AmountArticles = e.Articles.Count(),
                }).ToList();
            //Select * from Category where Name like 'T%' order by Name ASC


            // B2: Đổ dữ liệu lên categoryDTOBindingSource
            categoryDTOBindingSource.DataSource = ls;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var selectedCat = categoryDTOBindingSource.Current as CategoryDTO;

            if (selectedCat != null)
            {
                var res = MessageBox.Show("Are u sủa to xóa ??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    var db = new BlogDB();

                    var obj = db.Categories.Where(c => c.Id == selectedCat.Id).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Categories.Remove(obj);
                        db.SaveChanges();
                        LoadCategory();
                    }
                }

            }
        }
    }
}
