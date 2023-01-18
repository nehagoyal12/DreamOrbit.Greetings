using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.Data.Models
{
    public class EmailMessage
    {
        [Key]
        public int Id { get; set; }
        public string? Wish { get; set; }
        public string? Photo { get; set; }
        public int WishType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }


}
