using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameStore2.Custom_Controlls
{
    public partial class WindowBorderMaximizeBox : UserControl
    {
        Window parent;
        bool maximized = false;
        public WindowBorderMaximizeBox(Window parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public WindowBorderMaximizeBox()
        {
            InitializeComponent();
        }

        private void b_MinimizeBox_Click(object sender, RoutedEventArgs e)
        {
            this.parent.WindowState = WindowState.Minimized;
        }

        private void b_MaximizeBox_Click(object sender, RoutedEventArgs e)
        {
            if (!maximized)
            {
                this.parent.WindowState = WindowState.Maximized;
                maximized = true;
            }
            else
            {
                this.parent.WindowState = WindowState.Normal;
                maximized = false;
            }
        }

        private void b_Close_Click(object sender, RoutedEventArgs e)
        {
            this.parent.Close();
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.parent.DragMove();
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.parent.WindowState = WindowState.Maximized;
        }
    }
}
