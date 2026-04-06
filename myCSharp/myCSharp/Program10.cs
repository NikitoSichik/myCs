

class Figure
{
    public virtual void Draw() { Console.WriteLine("Дефолт фигура"); }

    public virtual double GetArea() { return 0.0; }
}
class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius) { Radius = radius; }
    public override void Draw()
    {
        Console.WriteLine("Круг:");
        var print_circle = """"
               *****
             *       *
            *         *
             *       *
               *****
            """";
        Console.WriteLine(print_circle);
    }

    public override double GetArea() { return Math.PI * Radius * Radius; }
}

class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override void Draw()
    {
        Console.WriteLine("Прямоугольник:");
        var printRectangle = """
            #*************************************#           
            *                                     +           
            *                                     +           
            *                                     +           
            *                                     +           
            *                                     +           
            *                                     +           
            #+++++++++++++++++++++++++++++++++++++#
            """;
        Console.WriteLine(printRectangle);
    }

    public override double GetArea() { return Width * Height; }
}

class FigureManager
{
    public Figure CreateFigure(string type, params double[] parameters)
    {
        switch (type.ToLower())
        {
            case "circle":
                if (parameters.Length < 1)
                    throw new ArgumentException("Для круга нужен радиус.");
                return new Circle(parameters[0]);

            case "rectangle":
                if (parameters.Length < 2)
                    throw new ArgumentException("Для прямоугольника нужны ширина и высота.");
                return new Rectangle(parameters[0], parameters[1]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        FigureManager manager = new FigureManager();

        Figure circle = manager.CreateFigure("circle", 3.0);
        circle.Draw();
        Console.WriteLine($"Площадь: {circle.GetArea():F2}");
        Console.WriteLine();

        Figure rect = manager.CreateFigure("rectangle", 4.0, 2.5);
        rect.Draw();
        Console.WriteLine($"Площадь: {rect.GetArea():F2}");
    }
}

//using System;
//using System.Runtime.Intrinsics.Arm;
//using System.Security.Cryptography;

//abstract class User
//{
//    public Guid id { get; } = Guid.NewGuid();
//    public string Name { get; set; }
//    public string Email { get; set; }
//    protected string PasswordHash { get; private set; }
//    public abstract void PerformAction(string src);
//    protected User(string Name, string Email, string Password)
//    {
//        Console.WriteLine($"Пользователь {Name} | {GetType().Name} вошёл в систему");
//        this.Name = Name;
//        this.Email = Email;
//        this.PasswordHash = HashPassword(Password);
//    }
//    public bool Login(string Password)
//    {
//        var inputHash = HashPassword(Password);
//        if (inputHash == PasswordHash) return true;
//        return false;
//    }
//    private string HashPassword(string password)
//    {
//        using (SHA256 sha = SHA256.Create())
//        {
//            byte[] PasswordBytes = System.Text.Encoding.UTF8.GetBytes(password);
//            byte[] HashBytes = sha.ComputeHash(PasswordBytes);
//            return Convert.ToBase64String(HashBytes);
//        }
//    }
//}

//class AdminUser(string Name, string Email, string Password) : User(Name, Email, Password)
//{
//    public override void PerformAction(string src)
//    {
//        Console.WriteLine($"Пользователь {Name} | {GetType().Name} удалил ресурс {src}");
//    }
//}

//class CustomerUser(string Name, string Email, string Password) : User(Name, Email, Password)
//{
//    public override void PerformAction(string src)
//    {
//        Console.WriteLine($"Пользователь {Name} | {GetType().Name} прочитал ресурс {src}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        User[] users = {
//            new AdminUser("Admin", "admin@pot.org", "adminpass"),
//            new CustomerUser("User1", "user@pot.org", "user1pass"),
//            new CustomerUser("User2", "user@pot.org", "user2pass"),
//            new CustomerUser("User3", "user@pot.org", "user3pass")
//        };
//        foreach (var user in users)
//        {
//            if (user.Login("adminpass")) user.PerformAction("пост 1");
//            if (user.Login("user3pass")) user.PerformAction("пост 3");
//        }
//    }
//}