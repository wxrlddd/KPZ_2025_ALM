using System;

namespace SingletonPattern
{
    public sealed class Authenticator
    {
        private static Authenticator instance;
        private static readonly object lockObj = new object();
        private bool isAuthenticated;
        private string currentUser;

        private Authenticator()
        {
            isAuthenticated = false;
            currentUser = string.Empty;
        }

        public static Authenticator GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                        instance = new Authenticator();
                }
            }
            return instance;
        }

        public bool Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                isAuthenticated = true;
                currentUser = username;
                Console.WriteLine($"Користувач {username} успішно увійшов");
                return true;
            }
            Console.WriteLine("Невірні дані для входу");
            return false;
        }

        public void Logout()
        {
            if (isAuthenticated)
            {
                Console.WriteLine($"Користувач {currentUser} вийшов");
                isAuthenticated = false;
                currentUser = string.Empty;
            }
        }

        public bool IsAuthenticated() => isAuthenticated;
        public string GetCurrentUser() => currentUser;
    }
}
