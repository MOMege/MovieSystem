using Domain.Entities.Commen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : User
    {
        [Key]
        [Required]
        public new  bool? IsAdmin { get; set; } = false;
    }
}
