using System.Windows;
using System.Windows.Controls;
using GameStore2.Custom_Controlls;

namespace GameStore2.Views
{
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            //Прикрепление панели управления к окну
            WindowBorder windowborder = new WindowBorder(this);
            windowborder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowborder);
        }
    }
}
