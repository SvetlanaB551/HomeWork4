void Ex25()
{
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

    int ReadData(string msg)

   { Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}


int PowAtoB(int numA,int numB) 
{
    int res =1;
    for (int i=0; i< numB; i++)
    {
        res = res * numA;
    }
    return res;
}
int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
PrintData("Число " + numA + " в степени " + numB  + "= ", PowAtoB(numA,numB));
}
Ex25();

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Ex27()
{
int ReadData(string msg)

   { Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int DigCount(int A)
{
    int res = 0;
    
    while (A > 0)
    {
        res = res + A % 10;
        A=A/10;
    }
    return res;
}

int A = ReadData("Введите целое число: ");
PrintData("Сумма цифр в числе = ",DigCount(A));
}
Ex27();

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void Ex29()
{
    int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[] Fill1DArr(int len, int lowBoard, int highBoard)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(lowBoard, highBoard + 1);
    }
    return array;
}
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
int arrLen = ReadData("Введите длину массива: ");
int lowBoard= ReadData("Введите нижнюю границу массива: ");
int highBoard= ReadData("Введите верхнюю границу массива: ");

int[] arr = Fill1DArr(arrLen, lowBoard, highBoard);
Print1DArr(arr);

}

Ex29();
