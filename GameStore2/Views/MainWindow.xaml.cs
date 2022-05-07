using System.Windows;
using System.Windows.Controls;
using GameStore2.Custom_Controlls;
using GameStore2.Models;

namespace GameStore2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Прикрепление панели управления к окну
            WindowBorder windowborder = new WindowBorder(this);
            windowborder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowborder);
        }
    }
}
