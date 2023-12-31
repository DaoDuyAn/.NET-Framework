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
    public partial class FormArticle : Form
    {
        ArticleDTO article;
        public FormArticle(ArticleDTO article = null)
        {
            InitializeComponent();

            this.article = article;

            LoadCategory();

            if (article != null)
            {
                // Cập nhật
                this.Text = "Cập nhật bài viết";
                labelTieuDe.Text = "Cập nhật";
                txtTieuDe.Text = article.Title;
                cbbDanhMuc.SelectedValue = article.IdCategory;
            }
        }

        void LoadCategory()
        {
            var db = new BlogDB();

            var ls = db.Categories.Select(c => new CategoryDTO
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
            cbbDanhMuc.DataSource = ls;
            cbbDanhMuc.DisplayMember = "Name";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var selCat = cbbDanhMuc.SelectedItem as CategoryDTO;
            if (article != null)
            {
                // Thêm mới
                var obj = new Article
                {
                    Title = txtTieuDe.Text,  
                    IdCategory = selCat.Id,
                };

                var db = new BlogDB();
                db.Articles.Add(obj);
                db.SaveChanges();

                DialogResult = DialogResult.OK;
            }
            else
            {
                // Cập nhật
                var db = new BlogDB();

                var obj = db.Articles.Where(a => a.Id == article.Id).FirstOrDefault();
                obj.Title = txtTieuDe.Text;
                obj.IdCategory = selCat.Id;
                db.SaveChanges();

                DialogResult = DialogResult.OK;
            }
        }
    }
}
