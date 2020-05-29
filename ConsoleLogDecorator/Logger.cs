using System;
using System.Diagnostics;

namespace ConsoleLogDecorator
{
    public class Logger : ILogService
    {
        public void Log(Exception error)
        {           
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry($"ERROR [{error}]", EventLogEntryType.Information, 101, 1);
            }

        }

        public void Log(string message)
        {            
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry($"INFO [{message}]", EventLogEntryType.Information, 101, 1);
            }
        }
    }
}
