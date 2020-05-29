using System;
using System.Diagnostics;

namespace ConsoleLogDecorator
{
    public class LogService : ILogService
    {
        private readonly ILogService decorator;
        public LogService(ILogService decorator)
        {
            this.decorator = decorator;
        }

        public void Log(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR [{error}]");
            Console.ForegroundColor = ConsoleColor.White;          

            decorator.Log(error);
        }

        public void Log(string message) 
        {           
            Console.WriteLine($"INFO [{message}]");          
         
            decorator.Log(message);
        }

    }
}
