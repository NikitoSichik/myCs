string name;
int num1, num2, age, num;

Console.WriteLine("Как тебя зовут?");
name = Console.ReadLine();
Console.WriteLine($"Ты {name}");

Console.WriteLine("Первое число:");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число:");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

Console.WriteLine("Сколько вам лет?");
age = int.Parse(Console.ReadLine());
if (age >= 18)
    Console.WriteLine("Ты совершеннолетний!");
else Console.WriteLine("Ты слишком маленький :)");

Console.WriteLine("Напиши число");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
    Console.WriteLine($"{num} * {i} = {num * i}");
