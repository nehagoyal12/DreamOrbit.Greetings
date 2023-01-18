using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.ErrorLog.Interface
{
    public interface IErrorLog
    {
        public void LogException(Exception ex);
        
     
    }
}
