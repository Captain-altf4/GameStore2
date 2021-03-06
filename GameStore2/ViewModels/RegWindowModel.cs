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
    class RegWindowModel : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;

        private BaseCommands changeToMainWindow;
        public BaseCommands ChangeToMainWindow
        {
            get
            {
                return changeToMainWindow??
                    (changeToMainWindow = new BaseCommands(obj =>
                    {
                        WindowsBuilder.ShowMainWindow();
                        CloseWindow();
                    }));
            }
        }

        private string userLogin;
        public string UserLogin
        {
            get { return userLogin; }
            set
            {
                userLogin = value;
                OnPropertyChanged("UserLogin");
            }
        }

        private string userMail;
        public string UserMail
        {
            get { return userMail; }
            set
            {
                userMail = value;
                OnPropertyChanged("UserMail");
            }
        }

        private BaseCommands createNewUser;
        public BaseCommands CreateNewUser
        {
            get
            {
                return createNewUser ??
                (createNewUser = new BaseCommands(obj =>
                {
                    using (DBContext db = new DBContext())
                    {
                        PasswordBox pb = (PasswordBox) obj;
                        string? password = pb.Password;
                        User? user = db.User.Where(u => u.Login == userLogin).FirstOrDefault();

                        if (userLogin == null)
                            MessageBox.Show("Введите логин!");

                        if (userMail == null)
                            MessageBox.Show("Введите почту!");

                        if (password == null)
                            MessageBox.Show("Введите пароль!");

                        /*if (repeatPassword.Password == null)
                            MessageBox.Show("Подтвердите пароль!");*/

                        if (!LoginData.CheckLogin(userLogin) ||
                        !LoginData.CheckMail(userMail) ||
                        !LoginData.CheckPassword(password))
                            MessageBox.Show("Данные введены неверно!");

                        /*if (password != repeatPassword.Password)
                            MessageBox.Show("Пароли не совпадают!");*/

                        if (user != null)
                            MessageBox.Show("Такой пользователь уже существует!");

                        else
                        {
                            int maxId = db.User.Max(u => u.Id);
                            User newUser = new User(maxId + 1, userLogin, userMail, password, 0);
                            db.User.Add(newUser);
                            db.SaveChanges();
                            MessageBox.Show("Пользователь cоздан!");
                        }
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
