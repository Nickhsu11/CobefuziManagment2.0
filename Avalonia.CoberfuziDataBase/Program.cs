using Avalonia;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia.CoberfuziDataBase;

sealed class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    
    // Running instructions :
    // Normaly with the GUI - dotnet run
    // Without the GUI - dotnet run --cli
    [STAThread]
    public static void Main(string[] args)
    {

        if (args.Length > 0 && args[0].Equals("cli", StringComparison.OrdinalIgnoreCase))
        {
            App.BuildServiceProvider();
            
            // Run the program on the command line
            using (var scope = App.ServiceProvider.CreateScope())
            {
                var commandLineApp = scope.ServiceProvider.GetRequiredService<CommandLineApp>();
                commandLineApp.Run();
            }
        }
        else
        {
            // Run the program on the GUI
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}
