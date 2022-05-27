using GameStore2.Custom_Controlls;
using GameStore2.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace GameStore2.Views
{
    public partial class StoreWindow : Window
    {
        public StoreWindow()
        {
            InitializeComponent();
            WindowBorderMaximizeBox windowborder = new WindowBorderMaximizeBox(this);
            windowborder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowborder);
        }
    }
}
