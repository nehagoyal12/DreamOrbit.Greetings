using DreamOrbit.Greetings.Data.Context;
using DreamOrbit.Greetings.Data.Models;
using DreamOrbit.Greetings.ErrorLog.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.ErrorLog
{
    public class ErrorLog : IErrorLog
    {
        private readonly GreetingsContext _greetingsContext;
        public ErrorLog(GreetingsContext greetingsContext) 
        { 
            _greetingsContext= greetingsContext;
        }

        public void LogException(Exception ex)
        {
            var error = new ErrorTraceLog
            {
                Message = ex.Message,
                LogTime = DateTime.Now,
                StackTrace = ex.StackTrace,
                MethodName = "ProcessBirthdayEmail"

            };
            _greetingsContext.errorTraceLogs.Add(error);
            _greetingsContext.SaveChanges();
        }






        /* public void LogException(string Message, string StackTrace, string MethodName, DateTime LogTime)
         {
             var logEntry = new ErrorTraceLog()
             {
                  Message= Message,
                  StackTrace= StackTrace,
                  MethodName= MethodName,
                  LogTime= LogTime

             };

             _greetingsContext.errorTraceLogs.Add(logEntry);
             _greetingsContext.SaveChanges();
         }*/




    }
}
