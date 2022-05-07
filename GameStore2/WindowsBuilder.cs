using GameStore2.ViewModels;
using GameStore2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore2
{
    public static class WindowsBuilder
    {
        public static void ShowMainWindow()
        {
            var window = new MainWindow();
            var viewModel = new MainWindowModel();
            window.DataContext = viewModel;

            //Создаётся делегат, внутрь которого подаются переменные
            //В него кладётся функция закрытия окна, которая вызывается в VM
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); }; 
            window.Show();
        }

        public static void ShowRegWindow()
        {
            var window = new RegWindow();
            var viewModel = new RegWindowModel();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }
    }
}
