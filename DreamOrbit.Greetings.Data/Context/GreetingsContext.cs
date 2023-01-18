using Azure.Identity;
using DreamOrbit.Greetings.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.Data.Context
{
    public class GreetingsContext : DbContext
    {
        public GreetingsContext(DbContextOptions<GreetingsContext> options) : base(options) 
        { 
        
        }

        public DbSet<Employee> employees { get; set; }

        public DbSet<MailSmtpDetail> mailSmtpDetails { get; set; }
        public DbSet<EmailMessage> emailMessage { get; set; }
        public DbSet<ErrorTraceLog> errorTraceLogs { get; set; }    

    }
}
