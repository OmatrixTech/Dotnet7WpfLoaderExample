using DotNet7.Wpf.CustomLoader;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Dotnet7WpfLoaderExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ServiceProvider? serviceProvider = null;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Create a service collection
            var services = new ServiceCollection();

            // Register your services
            services.AddSingleton<ICustomLoaderService, CustomLoaderService>();
            services.AddTransient<MainWindowViewModel>();
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
