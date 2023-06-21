//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double ReadInt(string text)
{
    System.Console.WriteLine(text);
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}
//
Double Resultation(double A, double B)
{
    
    double result = A;
    for (int i = 2; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}
//i+=1;}
double A = ReadInt("Введите число, которое потом возведёте в степень:");
double B = ReadInt("Введите степень:");
double C = Resultation(A, B);
System.Console.WriteLine("Ответ с функцией " + C);
if (B > 0)
{
    double result = A;
    for (int i = 2; i <= B; i++)
    {
        result = result * A;
        //i+=1;

    }
    System.Console.WriteLine(A + " в степени " + B + " равно " + result);
}
else if (B < 0)
{
    double result = A;
    for (int i = -2; B <= i; i--)
    {
        result = result * A;
    }
    System.Console.WriteLine(A + " в степени " + B + " равно " + (1 / result));
}
else { Console.WriteLine("Если вы ввели стень 0, то ответ будет 1"); }