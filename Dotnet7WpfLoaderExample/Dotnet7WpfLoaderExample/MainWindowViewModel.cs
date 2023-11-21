using DotNet7.Wpf.CustomLoader.Utility;
using DotNet7.Wpf.CustomLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Dotnet7WpfLoaderExample
{
    public class MainWindowViewModel
    {
        ICustomLoaderService? customLoaderService = null;
        DispatcherTimer? timer = null;
        public ICommand ShowLoaderWithoutInstance { get; }
        public MainWindowViewModel(ICustomLoaderService customLoaderService)
        {
            this.customLoaderService = customLoaderService;
            ShowLoaderWithoutInstance = new RelayCommand(()=>ShowLoader());
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10); // Adjust the interval as needed
            timer.Tick += Timer_Tick;
            timer.Start();
            //Dependency injection service handler
           // customLoaderService.ShowLoader();

            //Without instance method
            LoaderHandler.ShowLoader();
        }

        private void ShowLoader()
        {
            LoaderHandler.ShowLoader();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Dependency injection service handler
           // customLoaderService.HideLoader();

            //Without instance method
            LoaderHandler.HideLoader();
        }
    }
}
