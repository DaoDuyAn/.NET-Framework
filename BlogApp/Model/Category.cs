using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }



        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

    }
}
