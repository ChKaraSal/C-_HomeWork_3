//Задача №19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Задача №1");
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;
if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Да");
    }
    else
    {
        Console.WriteLine($"{number} - Нет");
    }
}
else
{
    Console.WriteLine($"Ошибка!: {number} - не является пятизначным");
}



//Задача 21
//Напишите программу, 
//которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Задача №2");
int x1 = ReadInt("Введите х для точки A: ");
int y1 = ReadInt("Введите y для точки A: ");
int z1 = ReadInt("Введите z для точки A: ");
int x2 = ReadInt("Введите х для точки B: ");
int y2 = ReadInt("Введите y для точки B: ");
int z2 = ReadInt("Введите z для точки B: ");
int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;
double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Задача №3");
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= x; i++)
{
    Console.WriteLine($"{i * i * i}, ");
}