using System.Windows;
using System.Windows.Controls;

namespace GameStore2.Views
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            LoadUser();
        }

        void LoadUser()
        {
            l_Login.Content = CurrentUser.Login;
            l_Balance.Content = CurrentUser.Balance + " р";
            i_Avatar.Source = DataTransform.ByteToJpg(CurrentUser.Avatar);
        }
    }
}
