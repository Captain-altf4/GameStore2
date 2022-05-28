using GameStore2.Custom_Controlls;
using GameStore2.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace GameStore2.Views
{
    public partial class StoreWindow : Window
    {
        UserControl? currentControl;
        ProfileControl? pc;
        LibraryControl? lc;
        public StoreWindow()
        {
            /*pc = null;
            lc = null;*/
            InitializeComponent();
            WindowBorderMaximizeBox windowborder = new WindowBorderMaximizeBox(this);
            windowborder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowborder);
        }

        /*private void b_Profile_Click(object sender, RoutedEventArgs e)
        {
            if (lc != null)
            {
                ContentGrid.Children.Remove(lc);
                lc = null;
            }
            if(pc == null)
            {
                pc = new ProfileControl();
                pc.SetValue(Grid.RowProperty, 2);
                pc.SetValue(Grid.ColumnProperty, 1);
                pc.SetValue(Grid.ColumnSpanProperty, 5);
                ContentGrid.Children.Add(pc);
            }
        }*/

        private void b_Profile_Click(object sender, RoutedEventArgs e)
        {
            if (currentControl != null)
            {
                ContentGrid.Children.Remove(currentControl);
            }
            pc = new ProfileControl();
            pc.SetValue(Grid.RowProperty, 2);
            pc.SetValue(Grid.ColumnProperty, 1);
            pc.SetValue(Grid.ColumnSpanProperty, 5);
            ContentGrid.Children.Add(pc);
            currentControl = pc;
        }

        private void b_Library_Click(object sender, RoutedEventArgs e)
        {
            if (currentControl != null)
            {
                ContentGrid.Children.Remove(currentControl);
            }
            lc = new LibraryControl();
            lc.SetValue(Grid.RowProperty, 2);
            lc.SetValue(Grid.ColumnProperty, 1);
            lc.SetValue(Grid.ColumnSpanProperty, 5);
            ContentGrid.Children.Add(lc);
        }
    }
}
