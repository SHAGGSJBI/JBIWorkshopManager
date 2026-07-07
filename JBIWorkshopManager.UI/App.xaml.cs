using JBI.WorkshopManager.UI.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using JBI.WorkshopManager.UI.Windows;

namespace JBI.WorkshopManager.UI;

public partial class App : Application
{
    private readonly IHost _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureWorkshopManager()
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        try
        {
            await _host.StartAsync();

            var mainWindow = _host.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Application failed during startup.");
            Shutdown();
        }
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        try
        {
            await _host.StopAsync();
        }
        finally
        {
            Log.CloseAndFlush();
            base.OnExit(e);
        }
    }
}