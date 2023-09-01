// Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
void FillArray(int[] ints)
{
    int size = ints.Length;
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        ints[i] = rnd.Next(0, 900);
    }
}
int FindNum(int[] array, int start, int end)
{
    //int count = 0;
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if ( array[i] >= start && array[i] <= end )
            count++;

    }
    return count;
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
int[] array123 = new int[123];
FillArray(array123);
PrintArray(array123);
System.Console.WriteLine(FindNum(array123, 10, 99));