// Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

void ChangeNegPos(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        
            array[i] *= -1; 
        
    }
}
void PrintArray(int[] array){
  int size = array.Length;
    for (int i = 0; i < size; i++)
    {  
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
int[] array = { -4, -8, 8, 2 };
PrintArray(array);
ChangeNegPos(array);
PrintArray(array);

