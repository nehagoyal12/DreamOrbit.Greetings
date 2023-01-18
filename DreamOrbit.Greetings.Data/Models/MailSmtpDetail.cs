using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.Data.Models
{
    public class MailSmtpDetail
    {
        [Key]
        public int Id { get; set; }
        public string? FromMailAddress { get; set; }
        public string? FromPassword { get; set;}
        public string? ServerName { get; set;}
        public int Port { get; set;}
        public bool IsEnableSsl { get; set;}
    }
}
