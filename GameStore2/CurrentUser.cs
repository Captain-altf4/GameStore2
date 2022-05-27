using System.Collections.Generic;
using GameStore2.Models;

namespace GameStore2
{
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Login { get; set; }
        public static int Balance { get; set; }
        public static string Mail { get; set; }
        public static byte[] Avatar { get; set; }
        public static List<Game> Games { get; set; }
    }
}
