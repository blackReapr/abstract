namespace ConsoleApp2.Models
{
    internal class Account
    {
        public string? Username { get; set; }
        public string? Password { get; set; }

        void Login(string username, string password)
        {
            if (!(username == "Admin" && password == "AdminEA18yr@")) Console.WriteLine("Username ve ya parol dogru deyil");
            Username = username;
            Password = password;
        }
    }
}
