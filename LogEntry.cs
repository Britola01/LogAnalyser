using System;

namespace LogAnalyzer
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }

        public LogEntry(DateTime timestamp, string level, string message)
        {
            Timestamp = timestamp;
            Level = level;
            Message = message;
        }
    }
}
