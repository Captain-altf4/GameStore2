using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameStore2.Custom_Controlls
{
    public partial class WindowBorder : UserControl
    {
        Window parent;
        public WindowBorder(Window parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public WindowBorder()
        {
            InitializeComponent();
        }

        private void b_Close_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.parent.Close();
        }

        private void b_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.parent.WindowState = WindowState.Minimized;
        }

        private void UserControl_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                parent.DragMove();
        }
    }
}
