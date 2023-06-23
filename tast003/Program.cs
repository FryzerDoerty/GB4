//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray(int[] arr, int A, int B){
    Random rand = new Random();
    
    for(int i=0; i<arr.Length; i++){
        arr[i] = rand.Next(A, B);
    }
}
void PrintArray(int[] arr){
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int A = ReadInt("Введите правую границу генерации чисел:");
int B = ReadInt("Введите левую границу генерации чисел:");
int sizeArray = ReadInt("Введите длину вашего массива, в диапазоне от 1, до 8:");
if(sizeArray<=8){
int[] array = new int[sizeArray];
FillArray(array, A, B);
PrintArray(array);}
else{System.Console.WriteLine("Не правильный диапазон!");}
//System.Console.WriteLine(A + B + C);