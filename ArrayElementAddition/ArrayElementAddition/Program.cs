// Program1.cs
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Progra45
{
    static async Task Main(string[] args)
    {
        string directoryPath = @"D:\training\Logs";
        Directory.CreateDirectory(directoryPath);

        string[] filePaths = { Path.Combine(directoryPath, "log1.txt"), Path.Combine(directoryPath, "log2.txt"), Path.Combine(directoryPath, "log3.txt") };

        var writeTasks = filePaths.Select((filePath, index) => AppendNumbersToFileAsync(filePath, index)).ToArray();
        await Task.WhenAll(writeTasks);

        Console.WriteLine("Data written to files in parallel.");
        Console.ReadLine();
    }

    static async Task AppendNumbersToFileAsync(string filePath, int index)
    {
        try
        {
            for (int i = 1; i <= 100; i++)
            {
                await AppendTextAsync(filePath, $"File {index + 1} - Number: {i}{Environment.NewLine}");
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
