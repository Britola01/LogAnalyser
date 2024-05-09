using System;
using System.Collections.Generic;
using System.Linq;

namespace LogAnalyzer {
    public static class LogAnalysisTools
    {
        public static void LogAnalysis(List<LogEntry> entries)
        {
            if (entries.Count == 0) {
                Console.WriteLine("Nenhum log para analisar.");
                return;
            }

            var countByLevel = entries.GroupBy(e => e.Level)
                                      .ToDictionary(g => g.Key, g => g.Count());

            foreach (var level in countByLevel)
            {
                Console.WriteLine($"{level.Key}: {level.Value}");
            }
        }
    }
}
