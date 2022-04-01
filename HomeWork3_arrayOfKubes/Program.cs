// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// например,          3 -> 1, 8, 27.                5 -> 1, 8, 27, 64, 125

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
    Console.Write($"{index*index*index}, ");
    index++;
}
Console.Write($"{index*index*index}.");
