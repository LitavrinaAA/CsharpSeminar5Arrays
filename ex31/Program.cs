// Задайте масив из 12 элементов, 
//заполненный случайными числами из промежутка[-9, 9]
//Найти сумму отрицательных и положительных элементов массива.
//Например в массиве [3,9,-8, 1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных -20
void FillArray(int[] ints)
{
    int size = ints.Length;
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        ints[i] = rnd.Next(-9, 10);
    }
}
void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write(array[i] + " ");

    }
    System.Console.WriteLine();
}

void SumPosNegNum(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) { sumPos += array[i]; }
        else
        {
            sumNeg += array[i];
        }
    }
    System.Console.WriteLine($"Сумма положительных чисел равна: {sumPos}");
    System.Console.WriteLine($"Сумма отрицательных чисел равна: {sumNeg}");

}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
SumPosNegNum(array);

