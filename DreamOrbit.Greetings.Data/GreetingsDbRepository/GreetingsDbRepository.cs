using DreamOrbit.Greetings.Data.Context;
using DreamOrbit.Greetings.Data.Interface;
using DreamOrbit.Greetings.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.Data.GreetingsDbRepository
{
    public class GreetingsDbRepository : IGreetingsDbRepository
    {
        private GreetingsContext _greetingContext;

        public GreetingsDbRepository(GreetingsContext greetingContext)
        {
            _greetingContext = greetingContext;
        }
        public async Task<List<Employee>> FetchTodayBirthdayEmployee()
        {
            var todayBirthday =await _greetingContext.employees.Where(
                                                     s => s.DateOfBirth.Month == DateTime.Today.Month &&
                                                     s.DateOfBirth.Day == DateTime.Today.Day).ToListAsync();
            return todayBirthday;
        }

        public async Task<MailSmtpDetail> FetchSmtpDetail()
        {
            return await _greetingContext.mailSmtpDetails.FirstOrDefaultAsync();
        }

        public async Task<List<EmailMessage>> FetchEmailMessage()
        {
            return await _greetingContext.emailMessage.ToListAsync();

            //return await _greetingContext.emailMessage.OrderBy(x => Guid.NewGuid().GetHashCode()).Take(1).ToListAsync();

        }



    }
}
