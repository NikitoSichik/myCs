//class Program
//{
//    static void ModifyItem(ref int item)
//    {
//        item += 5;
//    }

//    static void ModifyItems(List<string> items) {

//        for (int i = 0; i < items.Count; i++)
//        {
//            items[i] = $"{i + 1}. {items[i]}";
//        }
//    }

//    static void Main()
//    {
//        var number = 0;
//        var items = new List<string>() { "Hello", "World" };

//        Console.WriteLine(number);
//        foreach (var item in items) Console.WriteLine(item);

//        Console.WriteLine("\nПосле изменений\n");

//        ModifyItem(ref number);
//        ModifyItems(items);

//        Console.WriteLine(number);
//        foreach (var item in items) Console.WriteLine(item);
//    }
//}