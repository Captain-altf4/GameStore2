
using System.Windows;
using System.Windows.Controls;
using GameStore2.Custom_Controlls;

namespace GameStore2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowBorder windowborder = new WindowBorder(this);
            windowborder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowborder);
        }
    }
}
