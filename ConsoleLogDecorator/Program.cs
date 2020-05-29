using System;

namespace ConsoleLogDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var logservice = new LogService(logger);
            var service = new MathService(logservice);
            Console.WriteLine("Hello! Type two numbers:");
            try
            {
                var numberOne = Convert.ToInt32(Console.ReadLine());
                var numberTwo = Convert.ToInt32(Console.ReadLine());
                service.Average(numberOne, numberTwo);
            }
            catch (Exception ex)
            {
                logservice.Log(ex);
                throw;
            }
            

        }
    }
}
