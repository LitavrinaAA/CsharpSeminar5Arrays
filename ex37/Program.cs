// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 12 10


void FillArray(int[] array, int minValue, int maxValue){
    Random rnd = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
      array[i] = rnd.Next(minValue, maxValue); 
    }
}

void PrintArray(int[] array){
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
      System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
int[] multArrayElements(int[] array){
    int size = array.Length/2 + array.Length%2;
    int[] multArr = new int[size];
    int length = array.Length;
    for (int i = 0; i < length/2 ; i++)
    {
        multArr[i] = array[i]*array[length - 1 -i];
    }
    if (length%2 != 0){
        multArr[size-1] = array[size-1]; 
    }
    return multArr;

}
int size = 11;
int[] array = new int[size];
FillArray(array, 1, 10);
int[] multArr = multArrayElements(array);
PrintArray(array);
PrintArray(multArr);