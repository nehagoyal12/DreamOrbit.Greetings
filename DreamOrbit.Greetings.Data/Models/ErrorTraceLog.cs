using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.Data.Models
{
    public class ErrorTraceLog
    {
        [Key]
        public int Id { get; set; }
        public string? Message { get; set; }
        public string? StackTrace { get; set; }
        public DateTime LogTime { get; set; }
        public string? MethodName { get; set; }
    }
}
