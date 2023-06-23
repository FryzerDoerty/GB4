//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
string ReadInt(string text)
{
    System.Console.WriteLine(text);
    string number = Console.ReadLine()!;
    return number;
}
int Sum(string A)
{
    int sum = 0;
    for (int i = 0; i <= (A.Length - 1); i++)
    {
        char m = A[i];
        int num = (int)Char.GetNumericValue(m);
        sum = sum + num;
    }
    return sum;
}
string A = ReadInt("Введите число:");
int num = Sum(A);
System.Console.WriteLine(num);