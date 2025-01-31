using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.CoberfuziDataBase.Data;
using Avalonia.Markup.Xaml;
using Avalonia.CoberfuziDataBase.ViewModels;
using Avalonia.CoberfuziDataBase.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia.CoberfuziDataBase;

public partial class App : Application
{
    
    public static IServiceProvider ServiceProvider { get; private set; }
    
    public override void Initialize()
    {
        
        AvaloniaXamlLoader.Load(this);
        BuildServiceProvider();
        
    }

    public static void BuildServiceProvider()
    {

        // Make sure it doesn't reinitialize
        if (ServiceProvider is null)
        {

            var services = new ServiceCollection();
            
            // Configuration of the services
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
        }
    }

    // Configuration of the services so they know everything that exists
    // DI - Dependencie Injection
    private static void ConfigureServices(IServiceCollection services)
    {

        services.AddDbContext<AppDbContext>();
        
    }
    
    // When the framework is initialized it will be responsible for the creation
    // of the tables of the db
    public override void OnFrameworkInitializationCompleted()
    {

        using (var scope = ServiceProvider.CreateScope())
        {
            
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            
            // Deletes the content and the Tables get delleted
            dbContext.Database.EnsureDeleted();
            Console.WriteLine("DataBase : Existing Tables Dropped");
            
            // Creates the tables
            dbContext.Database.EnsureCreated();
            Console.WriteLine("DataBase : Tables Created");
            
        }

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = ServiceProvider.GetRequiredService<MainWindow>();
        }
        
        base.OnFrameworkInitializationCompleted();
    }
}