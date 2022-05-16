using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GameStore2
{
    public static class LoginData
    {
        public struct CurrentUser
        {
            public static int Id { get; set; }
            public static string Login { get; set; }
            public static string Mail { get; set; }
        }

        public static bool CheckLogin(string userLogin)
        {
            Regex rx = new Regex(@"^[a-zA-Z0-9-_]{3,32}$");
            return rx.IsMatch(userLogin);
        }

        public static bool CheckMail(string userMail)
        {
            Regex rx = new Regex(@"^((([0-9A-z]{1}[-0-9A-z\.]{0,30}[0-9A-z]?)|([0-9A-zА-я]{1}[-0-9A-zА-я\.]{0,30}[0-9A-zА-я]?))@([-A-Za-z]{1,}\.){1,}[-A-Za-z]{2,})$");
            return rx.IsMatch(userMail);
        }

        public static bool CheckPassword(string userPassword)
        {
            Regex rx = new Regex(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9A-z!@#$%^&*]{6,}");
            return rx.IsMatch(userPassword);
        }
    }
}
