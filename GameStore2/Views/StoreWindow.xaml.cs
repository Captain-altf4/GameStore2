using GameStore2.Custom_Controlls;
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

            LibraryControl lc = new LibraryControl();
            lc.SetValue(Grid.RowProperty, 2);
            lc.SetValue(Grid.ColumnProperty, 1);
            lc.SetValue(Grid.ColumnSpanProperty, 5);
            ContentGrid.Children.Add(lc);
        }
    }
}
