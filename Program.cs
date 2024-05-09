using System;
using System.Collections.Generic;

namespace LogAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "/usr/share/metasploit-framework/vendor/bundle/ruby/3.1.0/extensions/x86_64-linux/3.1.0/strptime-0.2.5/mkmf.log";

            try
            {
                var entries = LogParser.ParseLogFile(filePath);
                LogAnalysisTools.LogAnalysis(entries);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao analisar o arquivo de log: {ex.Message}");
            }
        }
    }
}
