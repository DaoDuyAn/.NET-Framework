
using BlogApp.DTO;
using BlogApp.Model;

namespace BlogApp
{
    public partial class Form1 : Form
    {
        public Form1()
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
                .Where(c => c.Name.StartsWith("T"))
                .OrderBy(c => c.Name)
                .Select(e => new CategoryDTO
                {
                    Id = e.Id,
                    Name = e.Name,
                    AmountArticles = e.Articles.Count(),
                }).ToList();
            //Select * from Category where Name like 'T%' order by Name ASC



            // B2: Đổ dữ liệu lên cbbDanhMuc
            cbbDanhMuc.DataSource = ls;
            cbbDanhMuc.DisplayMember = "Display";
        }

        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = cbbDanhMuc.SelectedItem as CategoryDTO;

            if (selectedCategory != null)
            {
                var db = new BlogDB();

                var ls = db.Articles
                    .Where(t => t.IdCategory == selectedCategory.Id)
                    .Select(t => new ArticleDTO
                    {
                        Id = t.Id,
                        IdCategory = t.IdCategory,
                        Title = t.Title,
                        Content = t.Content,
                    })
                    .ToList();

                articleDTOBindingSource.DataSource = ls;
            }
            else
            {
                articleDTOBindingSource.DataSource = null;
            }
        }
    }
}