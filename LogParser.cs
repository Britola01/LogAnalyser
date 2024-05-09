using System;
using System.Collections.Generic;
using System.IO;

namespace LogAnalyzer
{
    public static class LogParser
    {
        public static List<LogEntry> ParseLogFile(string filePath){
    var logEntries = new List<LogEntry>();
    if (!File.Exists(filePath)) {
        Console.WriteLine("Arquivo de log não encontrado: " + filePath);
        return logEntries;
    }

    string[] lines = File.ReadAllLines(filePath);
    Console.WriteLine($"Número de linhas lidas: {lines.Length}");
    
    foreach (var line in lines)
    {
        Console.WriteLine("Processando linha: " + line); 
        var parts = line.Split(']');
        if (parts.Length < 3) {
            Console.WriteLine("Linha ignorada, não possui partes suficientes.");
            continue;
        }

        try {
            var timestamp = DateTime.Parse(parts[0].Trim('[', ' '));
            var level = parts[1].Trim('[', ' ').ToUpper();
            var message = parts[2].TrimStart(' ');

            logEntries.Add(new LogEntry(timestamp, level, message));
        } catch (Exception ex) {
            Console.WriteLine($"Erro ao processar linha: {ex.Message}");
        }
    }
    return logEntries;
}
}
}