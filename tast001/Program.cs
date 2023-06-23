//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double ReadInt(string text)
{
    System.Console.WriteLine(text);
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double Resultation(double A, double B)
{

    double result = A;
    if (B > 0)
    {
        for (int i = 2; i <= B; i++)
        {
            result = result * A;
        }
    }
    else if (B < 0)

    {
        for (int i = -2; B <= i; i--)
        {
            result = result * A;
        }
        result = 1 / result;
    }
    else{
        result = A-A+1;
    }


    return result;

}
double A = ReadInt("Введите число, которое потом возведёте в степень:");
double B = ReadInt("Введите степень:");
double C = Resultation(A, B);
System.Console.WriteLine(A + " в степени " + B + " равно " + C);