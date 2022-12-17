// Написать программу, которая перевернет целочисленный массив
// последний элемент будет на первом, а первый на последнем

// инициализация массива
// обращение к длине массива 
// перебор чисел начиная с 0
// с выполнением условия достижения "середины" (половины массива)

int[] PrintArray(int[] array, int length)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
    }
    return array;
}

int[] Swap(int[] array, int length)
{
    for (int i = 0, j = length - 1; i < (length / 2); i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

int[] arr = new int[] {1, 2, 3, 4, 5, 6, 7};
Console.Write("Массив: ");
PrintArray(arr, arr.Length);
Console.WriteLine();

int[] newArray = Swap(arr, arr.Length);
Console.Write("Перевернутый массив: ");
PrintArray(newArray, newArray.Length);
Console.WriteLine();
