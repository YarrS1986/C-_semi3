// 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Пример, 14212 -> нет, 23432 -> да, 12821 -> да.

Console.Clear();

int Promt(string message)
{
    Console.Write(message);
    string strMessage = Console.ReadLine();
    int answer = int.Parse(strMessage);
    return answer;
}
int value = Promt("Введи пятизначное число: ");
valueLen = value.ToString().Length;

for (int i = 0; i < value.Lenght / 2; i++)
{
    if (value[i] != value[value.Lenght - i - 1])
        Console.WriteLine("нет");
}
Console.WriteLine("да");

// if (value > 9999 && value < 100000)
// {


//     Console.WriteLine("ок");
// }
// else Console.WriteLine("введи верное число!");


