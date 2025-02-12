public class Product
{
    public string Name { get; set; }
    public Product(string name)
    {
        Name = name;
    }
}
public class Program
{
    // Asynchronous method to fetch products
    public async Task<List<Product>> FetchProductAsync()
    {
        await Task.Delay(1500);
        return new List<Product>
        {
            new Product("Product 1 ECO BAG"),
            new Product("Product 2 REUSABLE STRAW"),
            new Product("Product 3"),
            new Product("Product 4"),
            new Product("Product 5")
        };
    }
    // Asynchronous method to display products
    public async Task DisplayProductsAsync()
    {
        List<Product> products = await FetchProductAsync();
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }
    }
    public static async Task Main(string[] args)
    {
        // Calling the asynchronous methods
        Program program = new Program();
        await program.DisplayProductsAsync();
    }
}
// Starter code
/* public class Program
{
public _____ Task<string> DownloadFileAsync(string fileName)
{
    Console.WriteLine($"Starting download of {fileName}...");
    _____ Task.Delay(3000); // Simulate a 3-second download time
    Console.WriteLine($"Completed download of {fileName}.");
    return $"{fileName} content";
}

public _____ Task DownloadFilesAsync()
{
    // Start downloading "File1.txt" and "File2.txt" concurrently
    var downloadTask1 = DownloadFileAsync("File1.txt");
    var downloadTask2 = DownloadFileAsync("File2.txt");


    // Wait for both downloads to complete
    _____ Task.WhenAll(downloadTask1, downloadTask2);
    Console.WriteLine("All downloads completed.");
}

public static _____ Task Main(string[] args)
{
    Program program = new Program();
    _____ program.DownloadFilesAsync();
}
} */ 