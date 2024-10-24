using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string? CategoryName { get; set; } 
        public int? ParentID { get; set; }
        [ForeignKey("ParentID")]
        public virtual ICollection<Category>? Subcategories { get; set; }
        public virtual Category ParentCategory { get; set; }
        public ICollection<Movie>? Movies { get; set; }
        


    }
}
