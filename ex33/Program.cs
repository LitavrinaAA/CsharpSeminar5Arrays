// Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

bool FindNum(int[] array, int num)
{
    //int count = 0;
    bool findNum = false;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] == num) { findNum = true; }
        
    }
    return findNum;
}
void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void Main(int[] array, int num){
    PrintArray(array);
System.Console.WriteLine(num);
System.Console.WriteLine((FindNum(array, num)) ? "да":"нет");
}

Main(new int[] { 6, 7, 19, 345, 3 }, 4);
Main(new int[] { 6, 7, 19, 345, 3 }, 3);

