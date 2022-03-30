//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//например, A (3,6); B (2,1) -> 5,09; A (7,-5); B (1,-1) -> 7,21

Console.Clear();

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
int dotX1 = Promt("Введи число X1: ");
int dotY1 = Promt("Введи число Y1: ");
int dotX2 = Promt("Введи число X2: ");
int dotY2 = Promt("Введи число Y2: ");

double sum = Math.Sqrt(((dotX2-dotX1)*(dotX2-dotX1))+((dotY2-dotY1)*(dotY2-dotY1)));

Console.WriteLine($"сумма={sum}");