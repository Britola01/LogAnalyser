using System;
using System.Collections.Generic;

namespace LogAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "";

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
