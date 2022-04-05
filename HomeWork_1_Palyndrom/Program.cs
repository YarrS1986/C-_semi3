// 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Пример, 14212 -> нет, 23432 -> да, 12821 -> да.

Console.Clear();

// int Promt(string message)
// {
//     Console.Write(message);
//     string strMessage = Console.ReadLine();
//     int answer = int.Parse(strMessage);
//     return answer;
// }

Console.Write("введи число = ");
string num = Console.ReadLine();
int len = num.Length;

int i = 0;
while (i < len / 2)
{
    if (num[i] == num[len - 1 - i])
    {
        Console.WriteLine("полиндром");
        i++;
    }
    else
    {
        Console.WriteLine("не полиндром");
        break;
    }
}
//for (int i = 0; i < len / 2; i++)




// int value = int.Parse(strMessage);
// int[] array = new int[int.Parse(strMessage)];

// // int value = Promt("Введи пятизначное число: ");
// // int num = value.Lenght;

// 
// {
//     Console.WriteLine(array[i]);
//     i++;
// if (array[i] == array[Lenght - i])
//     Console.WriteLine(array[i]);

//Console.WriteLine("полиндром");

// 0 1 2 3 4 5 6


// if (value > 9999 && value < 100000)
// {


//     Console.WriteLine("ок");
// }
// else Console.WriteLine("введи верное число!");


