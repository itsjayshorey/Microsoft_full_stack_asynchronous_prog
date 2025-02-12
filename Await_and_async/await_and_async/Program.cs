using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Program()
{
    public async Task DownloadDataAsync(int a)
    {
         
        Console.WriteLine($"Downloading data...{a}");
        await Task.Delay(3000);
        Console.WriteLine($"Data downloaded!{a}");
    }
    public async Task DownloadDataAsync2(int b)
    {
        Console.WriteLine($"Downloading data...{b}");
        await Task.Delay(3000);
        Console.WriteLine($"Data downloaded!{b}");
    }
    public static async Task Main(string[] args)
    {
        Program program = new Program();
        await program.DownloadDataAsync(0);
        Console.WriteLine("Main method done!");
        Task task1  = program.DownloadDataAsync(1);
        Task task2  = program.DownloadDataAsync2(2);
        Task task3  = program.DownloadDataAsync(3);
        Task task4  = program.DownloadDataAsync2(4);
        await Task.WhenAll(task1, task2, task3, task4);
        Console.WriteLine("Main method done!");

    }
}