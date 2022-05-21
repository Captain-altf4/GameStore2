using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using GameStore2.Commands;
using GameStore2.ModelContext;
using GameStore2.Models;

namespace GameStore2.ViewModels
{
    class MainWindowModel : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;

        private BaseCommands changeToRegWindow;

        public BaseCommands ChangeToRegWindow
        {
            get
            {
                //Если Null, тогда выполнится код ниже
                //Если не Null, то возьмёт переменную как есть
                return changeToRegWindow ??
                    (changeToRegWindow = new BaseCommands(obj =>
                    {
                        WindowsBuilder.ShowRegWindow();
                        CloseWindow();
                    }));
            }
        }

        private string currentLogin;

        public string CurrentLogin
        {
            get { return currentLogin; }
            set
            {
                currentLogin = value;
                OnPropertyChanged("CurrentLogin");
            }
        }

        private BaseCommands loginUser;

        public BaseCommands LoginUser
        {
            get
            {
                return loginUser ??
                (loginUser = new BaseCommands(obj =>
                {
                    PasswordBox pb = (PasswordBox)obj;
                    using (DBContext db = new DBContext())
                    {
                        var user = db.User.Where(u => u.Login == currentLogin && u.Password == pb.Password).FirstOrDefault();
                        if (user != null)
                        {
                            LoginData.CurrentUser.Id = user.Id;
                            LoginData.CurrentUser.Login = user.Login;
                            LoginData.CurrentUser.Mail = user.Mail;
                            WindowsBuilder.ShowStoreWindow();
                            CloseWindow();
                        }
                        else
                            MessageBox.Show("Пользователь не найден!");
                    }
                }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}