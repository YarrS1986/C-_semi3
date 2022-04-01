//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//например, A (3,6,8); B (2,1,-7), -> 15.84            A (7,-5, 0); B (1,-1,9) -> 11.53

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
int dotZ1 = Promt("Введи число Z1: ");
int dotX2 = Promt("Введи число X2: ");
int dotY2 = Promt("Введи число Y2: ");
int dotZ2 = Promt("Введи число Z2: ");

double sum = Math.Sqrt(((dotX2-dotX1)*(dotX2-dotX1))+((dotY2-dotY1)*(dotY2-dotY1))+((dotZ2-dotZ1)*(dotZ2-dotZ1)));

Console.WriteLine($"Расстояние между точками = {Math.Round(sum, 2)}");