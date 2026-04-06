using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

abstract class User
{
    public Guid id { get; } = Guid.NewGuid();
    public string name { get; set; }
    public string Email { get; set; }
    protected string PasswordHash { get; private set; }
    private string HashPassword(string password)
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] PasswordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] HashBytes = sha.ComputeHash(PasswordBytes);
            return Convert.ToBase64String(HashBytes);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine();
    }
}