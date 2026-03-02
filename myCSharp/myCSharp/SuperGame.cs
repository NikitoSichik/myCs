class Human { public string Name; }

class Program
{
    static void Main()
    {
        int num1 = 123;
        int num2 = num1;
        Console.WriteLine($"num1: {num1}, num2: {num2}");
        num2 = 555;
        Console.WriteLine($"num1: {num1}, num2: {num2}");
        Human a = new Human() { Name = "a"};
        Human b = a;
        Console.WriteLine($"a name: {a.Name}, b name: {b.Name}");
        b.Name = "b";
        Console.WriteLine($"a name: {a.Name}, b name: {b.Name}");

        string str1 = "Hello";
        string str2 = str1;
        Console.WriteLine($"первойя строка: {str1}, вторая строка: {str2}");
        str2 = "World";
        Console.WriteLine($"первойя строка: {str1}, вторая строка: {str2}"); // Ha-HA
    }
}