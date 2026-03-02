//class Car
//{
//    public string Brand;
//    public string Model;
//    public int Year;
//    public string Color;

//    public Car(string brand, string model, int year, string color)
//    {
//        this.Brand = brand;
//        this.Model = model;
//        this.Year = year;
//        this.Color = color;
//    }

//    public void Dispay_info()
//    {
//        Console.WriteLine($"Брэнд - {Brand}, Модель - {Model}, {Year} года, цвет - {Color}");
//    }
//}
//// Хе-хе, привет
//class Program
//{
//    static void Main()
//    {
//        Car car1 = new Car("car1", "model_car1", 2026, "Не чёрный");
//        Car car2 = new Car("car2", "model_car2", 2027, "Не белый");
//        Car car3 = new Car("car3", "model_car3", 2029, "чёрный");

//        car1.Dispay_info();
//        car2.Dispay_info();
//        car3.Dispay_info();
//    }
//}


class Human
{
    //инкапсуляция
    private double height;
    public string Name;
    public int Age;
    private double Height;
    public double Weight {
        get {
            Console.WriteLine("поле было прочитанно");
            return height;
        }
        set
        {
            height=value; 
            Console.WriteLine("поле изменено");
        }
    
    }

    public double GetWeight()
    {
        Console.WriteLine("поле Weight было прочитано");
        return Weight;
    }

    public void SetWeight(double newWeight)
    {
        Console.WriteLine("поле Weight было изменено");
        Weight = newWeight;
    }

    public Human(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public void Hello(Human human)
    {
        Console.WriteLine($"Привет, {human.Name}, меня зовут {this.Name}");
    }
    public void Hello(string Name)
    {
        Console.WriteLine($"Привет, {Name}, меня зовут {this.Name}");
    }
}

class Program
{
    static void Main()
    {
        Human petya = new Human("Петя", 30);
        Human vasya = new Human("Вася", 30);

        petya.Hello(vasya);
        vasya.Hello(petya);
    }
}