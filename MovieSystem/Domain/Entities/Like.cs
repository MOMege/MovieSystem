using Domain.Entities.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Like
    {
        public int Id { get; set; }

        // if write userId not implemented ??
        public int UseerId { get; set; }
        public bool IsLike { get; set; }
        public int ReviewId {  get; set; }
        public Review? Review { get; set; }
        
        public User? User { get; set; }
    }
}
