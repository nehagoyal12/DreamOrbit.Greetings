using DreamOrbit.Greetings.Component.Interface;
using DreamOrbit.Greetings.Data.Context;
using DreamOrbit.Greetings.Data.Interface;
using DreamOrbit.Greetings.Data.Models;
using DreamOrbit.Greetings.EmailBodyComponent.Interface;
using DreamOrbit.Greetings.ErrorLog.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.Component.GreetingsComponent
{
    public class GreetingsComponent : IGreetingsComponent
    {
        private readonly IGreetingsDbRepository _greetingDbRepository;
        private readonly IEmailComponent _emailComponent;
        private readonly IErrorLog _errorLog;
     

        public GreetingsComponent(IGreetingsDbRepository greetingDbRepository,IEmailComponent emailComponent,IErrorLog errorLog)
        {
            _greetingDbRepository = greetingDbRepository;
            _emailComponent = emailComponent;
            _errorLog = errorLog;
          
        }
        public async Task<bool> ProcessBirthdayEmail()
        {
            try
            {
                var employees = await _greetingDbRepository.FetchTodayBirthdayEmployee();

              /*  int x = 10; int y = 0;
                int z = x / y;
*/
                // fetch smtp server detail
                var smtpDetail = await _greetingDbRepository.FetchSmtpDetail();

                // fetch random birthday wish and images
                var emailmessage = await _greetingDbRepository.FetchEmailMessage();

                foreach (var employee in employees)
                {
                    // Prepare email body for each loop.
                    var email = _emailComponent.PrepareEmail(employee, emailmessage);


                    // Send email.
                    var result = _emailComponent.SendEmail(smtpDetail, email);

                }
            }
            catch (Exception ex)
            {

                _errorLog.LogException(ex);

            }

            return true;
        }

        
      

       

    }
}
