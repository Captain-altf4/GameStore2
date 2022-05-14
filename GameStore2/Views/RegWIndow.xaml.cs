using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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

        private void tb_Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginData.CheckLogin(tb_Login.Text))
                tb_Login.Foreground = new SolidColorBrush(Colors.Green);
            else
                tb_Login.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void tb_Mail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginData.CheckMail(tb_Mail.Text))
                tb_Mail.Foreground = new SolidColorBrush(Colors.Green);
            else
                tb_Mail.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void pb_Password1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (LoginData.CheckPassword(pb_Password1.Password))
                pb_Password1.Foreground = new SolidColorBrush(Colors.Green);
            else
                pb_Password1.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void pb_Password2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pb_Password2.Password == pb_Password1.Password)
                pb_Password2.Foreground = new SolidColorBrush(Colors.Green);
            else
                pb_Password2.Foreground = new SolidColorBrush(Colors.Red);
        }
    }
}
