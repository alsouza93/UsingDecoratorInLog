
namespace ConsoleLogDecorator
{
    public class MathService
    {
        private readonly ILogService logService;
        public MathService(ILogService logService)
        {
            this.logService = logService;
        }
        public void Average(int numberOne, int numberTwo)
        {
            var average = (numberOne + numberTwo) / 2;
            logService.Log($"Average: [{average}]");           
        }
    }
}
