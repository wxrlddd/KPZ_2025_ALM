using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Завдання 3: Патерн Одинак ===");

            
            var auth1 = Authenticator.GetInstance();
            var auth2 = Authenticator.GetInstance();

            
            Console.WriteLine($"Чи однаковий екземпляр? {ReferenceEquals(auth1, auth2)}");

            
            auth1.Login("admin", "password");
            Console.WriteLine($"Через auth2: IsAuthenticated = {auth2.IsAuthenticated()}");

        
            auth2.Logout();
            Console.WriteLine($"Через auth1: IsAuthenticated = {auth1.IsAuthenticated()}");
        }
    }
}
