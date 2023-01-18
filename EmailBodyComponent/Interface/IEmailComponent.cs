using DreamOrbit.Greetings.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DreamOrbit.Greetings.EmailBodyComponent.Interface
{
    public interface IEmailComponent
    {
        public Email PrepareEmail(Employee employee,List<EmailMessage> emailMessage);
        public bool SendEmail(MailSmtpDetail mailSmtpDetail,Email request);
        


    }
}
