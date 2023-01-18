using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DreamOrbit.Greetings.Data.Models
{
    public class Email
    {
        public string? Subject { get; set; }
        public string? To { get; set; } 
        public string? CC { get; set; }
        public string? Body { get; set; }
        public string? BCC { get; set; }
        public string? Photo { get; set; }

    }
}
