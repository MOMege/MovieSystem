using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description {  get; set; }
        public string? Image { get; set; }
        public string? Video { get; set; }
        public bool Isfree {  get; set; }
        public int CategoryId {  get; set; }
        public Category? Category { get; set; }
        public ICollection<Review>? Reviews { get; set; }



    }
}
