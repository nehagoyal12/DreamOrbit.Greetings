using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? EmailAddress { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AnniversaryDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DateOfJoining { get; set; }

    }
}
