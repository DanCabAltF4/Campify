using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Session
    {
        public static string Token { get; private set; }
        public static int UserId { get; private set; }
        public static string Rol { get; private set; }

        public static bool IsAuthenticated => !string.IsNullOrWhiteSpace(Token);

        public static void Login(string token, int userId, string rol)
        {
            Token = token;
            UserId = userId;
            Rol = rol;
        }

        public static void Logout()
        {
            Token = null;
            UserId = 0;
            Rol = null;
        }
    }
}
