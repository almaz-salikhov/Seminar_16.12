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

void Swap(ref int a, ref int b) // первый и последний элементы, мменяем местами
{
    int temp = a;
    a = b;
    b = temp;
}

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 }; // заданный массив

for (int i = 0, j = arr.Length - 1; i < (arr.Length / 2); i++, j--)
{
    Swap(ref arr[i], ref arr[j]);
}

for (int i = 0; i < arr.Length; i++) // Print перевернутого
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

// Console.Write("Массив: ");
// PrintArray(arr, arr.Length);
// Console.WriteLine();

// int[] newArray = Swap(arr, arr.Length);
// Console.Write("Перевернутый массив: ");
// PrintArray(newArray, newArray.Length);
// Console.WriteLine();
