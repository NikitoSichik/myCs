string[] depertmants = { "Отдел_1", "Отдел_2", "Отдел_3", "Отдел_4", "Отдел_5", "Отдел_6" };
string[] employees = { "login_1", "login_2", "login_3", "login_4", "login_5", "login_6", "login_7", "login_8", "login_9", "login_10" };

string[][] org = new string[depertmants.Length][];
org[0] = new string[] { employees[0], employees[1] };
org[1] = new string[] { };
org[2] = new string[] { employees[2] };
org[3] = new string[] { employees[3], employees[4] };
org[4] = new string[] { employees[5], employees[6], employees[7], employees[8] };
org[5] = new string[] { employees[9] };

for(int i = 0; i < org.Length; i++)
{
    if (org[i].Length == 0)
    {
        Console.WriteLine($"{depertmants[i]}: —");
    }
    else
    {
        Console.Write($"{depertmants[i]}: ");
        for (int j = 0; j < org[i].Length; j++)
        {
            Console.Write(org[i][j]);
            if (j < org[i].Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("\nКоличество сотрудников по отделам:");
int maxEmployees = 0;
for (int i = 0; i < org.Length; i++)
{
    int count = org[i].Length;
    Console.WriteLine($"{depertmants[i]}: {count}");
    if (count > maxEmployees)
        maxEmployees = count;
}

Console.WriteLine($"\nМаксимальное число сотрудников в отделе: {maxEmployees}");
Console.Write("Отделы с максимальным числом сотрудников: ");
for (int i = 0; i < org.Length; i++)
{
    if (org[i].Length == maxEmployees)
        Console.Write($"{depertmants[i]} ");
}
Console.WriteLine();

Console.Write("Пустые отделы: ");
bool hasEmpty = false;
for (int i = 0; i < org.Length; i++)
{
    if (org[i].Length == 0)
    {
        Console.Write($"{depertmants[i]} ");
        hasEmpty = true;
    }
}
if (!hasEmpty)
    Console.Write("отсутствуют");
Console.WriteLine();