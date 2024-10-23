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
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? Name { get; set; }
        
        public int? ParentID { get; set; }
        [ForeignKey("ParentID")]
        public virtual List<Category>? Subcategories { get; set; }
        public ICollection<Movie>? Movies { get; set; }
        


    }
}
