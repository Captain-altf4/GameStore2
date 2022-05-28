using GameStore2.Custom_Controlls;
using System.Windows;
using System.Windows.Controls;

namespace GameStore2.Views
{
    public partial class StoreWindow : Window
    {
        UserControl? currentControl;
        LibraryControl? lc;
        FriendsControl? fc;
        ProfileControl? pc;
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
                ContentGrid.Children.Remove(currentControl);
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
                ContentGrid.Children.Remove(currentControl);
            lc = new LibraryControl();
            lc.SetValue(Grid.RowProperty, 2);
            lc.SetValue(Grid.ColumnProperty, 1);
            lc.SetValue(Grid.ColumnSpanProperty, 5);
            ContentGrid.Children.Add(lc);
        }

        private void b_Friends_Click(object sender, RoutedEventArgs e)
        {
            if (currentControl != null)
                ContentGrid.Children.Remove(currentControl);
            fc = new FriendsControl();
            fc.SetValue(Grid.RowProperty, 2);
            fc.SetValue(Grid.ColumnProperty, 1);
            fc.SetValue(Grid.ColumnSpanProperty, 5);
            ContentGrid.Children.Add(fc);
        }
    }
}
