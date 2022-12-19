// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.

Console.WriteLine("Введите размер будущего массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRandom(int length) // создаем случайно массив, вводя размер массива
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 10);
        Console.Write($"{array[i]} ");
    }
    return array; // возвращает массив
}
int SumOfProductOfPairs(int[] array, int length) // сумма произведений пар чисел
{
    int sum = 0;
    int currentProduct = 0;
    for (int i = 0; i < length / 2; i++)
    {
        currentProduct = array[i] * array[length - 1 - i];
        sum = sum + currentProduct;
    }
    return sum;
}

int[] myArray = CreateArrayRandom(N);
Console.WriteLine();
Console.WriteLine($"Сумма произведений пар чисел: {SumOfProductOfPairs(myArray, N)}");
