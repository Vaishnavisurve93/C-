// Program2.cs
using System;
using System.IO;
using System.Threading.Tasks;

class Program2
{
    static async Task Main(string[] args)
    {
        string directoryPath = @"D:\training\Logs";
        Directory.CreateDirectory(directoryPath);

        string filePath = Path.Combine(directoryPath, "delayedLog.txt");

        await AppendNumbersToFileWithDelayAsync(filePath);
        Console.WriteLine("Data written to delayedLog.txt with delay.");
    }

    static async Task AppendNumbersToFileWithDelayAsync(string filePath)
    {
        try
        {
            for (int i = 1; i <= 100; i++)
            {
                await AppendTextAsync(filePath, $"Delayed File - Number: {i}{Environment.NewLine}");
                await Task.Delay(200); // Delay of 200 milliseconds
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while writing to {filePath}: {ex.Message}");
        }
    }

    static async Task AppendTextAsync(string filePath, string text)
    {
        try
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                await writer.WriteAsync(text);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while appending text to {filePath}: {ex.Message}");
        }
    }
}
