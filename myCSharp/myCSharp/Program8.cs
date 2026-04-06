//class Animal (string Name, string Type, int Age)
//{
//    public string Name { get; set; } = Name;
//    public string Type { get; set; } = Type;
//    public int Age { get; set; } = Age;
//    public void MakeSound() { Console.WriteLine($"Животное: {Name} издаёт звук"); }
//}

//class Cat(string Name, string Type, int Age) : Animal (Name, Type, Age) { }
//class Dog(string Name, string Type, int Age) : Animal (Name, Type, Age) { }
//class Program
//{
//    static void Main()
//    {
//        var dog = new Dog("Бобик", "Чёткий", 8);
//        var cat = new Cat("Пушок", "Убийца", 9);
//        dog.MakeSound();
//        cat.MakeSound();
//    }
//}



//class Program
//{
//    static int Dlina(string str){return str.Length;}
//    static void Main()
//    {
// Задание 1
//try
//{
//    int[] arr = { 3, 4, 5, 6 };
//    Console.WriteLine("Введите число от 0 до 9");
//    int index = int.Parse(Console.ReadLine());
//}
//catch (IndexOutOfRangeException ex) { Console.WriteLine("Индекс не в диапазоне массива!"); }

// Задание 2
//try
//{
//    Console.WriteLine("Введите строку int");
//    string str = Console.ReadLine();
//    int num = int.Parse(str);
//}
//catch (FormatException ex) { Console.WriteLine("Введите коректное целое число"); }
//catch (OverflowException ex) { Console.WriteLine("Число выходит за пределы int!"); }

// Задание 3
//        try
//        {
//            Console.WriteLine("Введите строку");
//            string str = Console.ReadLine();
//            if (str == "") throw new ArgumentNullException("Строка пуста");
//            Dlina(str);
//        }
//        catch (ArgumentNullException ex) { Console.WriteLine("Строка не может быть null!"); }
//        catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
//    }
//}


//class PasswordExeption(string msg) : Exception(msg) { }
//class IsLetterPassExeption(string msg) : PasswordExeption(msg) { }
//class IsUpperExeption(string msg) : PasswordExeption(msg) { }
//class IsLowerExeption(string msg) : PasswordExeption(msg) { }
//class IsDigitExeption(string msg) : PasswordExeption(msg) { }
//class CheckPassword
//{
//    public CheckPassword(string pass) { Password = pass; }
//    private string password;
//    public string Password
//    {
//        get { return password; }
//        set
//        {
//            List<PasswordExeption>errors = new List<PasswordExeption>();
//            bool IsLetter = false;
//            bool IsUpper = false;
//            bool IsLower = false;
//            bool IsDigit = false;
//            foreach (char ch in value)
//            {
//                if (char.IsLetter(ch)) { IsLetter = true; }
//                if (char.IsUpper(ch)) { IsUpper = true; }
//                if (char.IsLower(ch)) { IsLower = true; }
//                if (char.IsDigit(ch)) { IsDigit = true; }
//            }
//            if (!IsLetter) errors.Add(new IsLetterPassExeption("В пароле отсутствует буква"));
//            if (!IsUpper) errors.Add(new IsUpperExeption("В пароле отсутствует буква высокого регистра"));
//            if (!IsLower) errors.Add(new IsLowerExeption("В пароле отсутствует буква высокого регистра"));
//            if (!IsDigit) errors.Add(new IsDigitExeption("В пароле отсутствует буква"));

//            if (errors.Any()) throw new AggregateException("Пароль не прошёл проверку", errors);

//            password = value;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            var pass = new CheckPassword("");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {


//        try
//        {
//            Console.WriteLine("Введите первое число: ");
//            int num1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число: ");
//            int num2 = int.Parse(Console.ReadLine());
//            int reslt = num1 / num2;
//            Console.WriteLine($"Результат: {reslt}");
//        }
//        catch (DriveNotFoundException ex) {
//            Console.WriteLine(ex.Message);
//        }
//        catch
//        {
//            Console.WriteLine("неизвестная ошибочка :(");
//        }

//        Console.WriteLine("Програмка завершена");
//    }
//}