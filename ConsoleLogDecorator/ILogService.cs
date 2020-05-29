using System;

namespace ConsoleLogDecorator
{
    public interface ILogService
    {
        void Log(Exception error);
        void Log(string message);
    }
}