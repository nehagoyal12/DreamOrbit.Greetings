using DreamOrbit.Greetings.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.Component.Interface
{
    public interface IGreetingsComponent
    {
        public Task<bool> ProcessBirthdayEmail();
      
    }
}
