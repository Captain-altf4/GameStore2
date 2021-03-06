using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace GameStore2.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Login { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public byte[] Avatar { get; set; }
        public decimal Balance { get; set; }
        public virtual List<Game> Games { get; set; }

        public User()
        {
            Id = 0;
            Login = "";
            Mail = "";
            Password = "";
            Avatar = new byte[0];
            Balance = 0;
            Games = new List<Game>();
        }
        public User(int id, string login, string mail, string password, decimal balance)
        {
            Id = id;
            Login = login;
            Mail = mail;
            Password = password;
            BitmapImage image = new BitmapImage(new Uri("Images/Empty_Avatar.png", UriKind.Relative));
            Avatar = DataTransform.JpgToByte(image);
            Balance = balance;
            Games = new List<Game>();
        }
    }
}
