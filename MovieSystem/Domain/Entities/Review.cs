using Domain.Entities.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }
         public int UserId {  get; set; }
        public User? User { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        public ICollection<Like>? Like { get; set; }

        

    }
}
