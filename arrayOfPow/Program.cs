// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// например,          5 -> 1, 4, 9, 16, 25.                2 -> 1,4

Console.Clear();

int Promt(string message)
{
    Console.Write(message);
    string strMessage = Console.ReadLine();
    int answer = int.Parse(strMessage);
    return answer;
}

int array = Promt("Введи длину массива = ");
int index = 1;

while (index < array)
{
    Console.Write($"{index*index}, ");
    index++;
}
Console.Write($"{index*index}.");