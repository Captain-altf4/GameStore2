using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore2.Models;

namespace GameStore2
{
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Login { get; set; }
        public static string Mail { get; set; }
        public static byte[] Avatar { get; set; }
        public static List<Game> Games { get; set; }
    }
}
