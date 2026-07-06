using Microsoft.Extensions.Hosting;

namespace JBIWorkshopManager.UI;

public static class Program
{
    public static IHostBuilder CreateHostBuilder(string[]? args = null)
    {
        return Host.CreateDefaultBuilder(args);
    }
}