// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь, без массива

// запросить сколько будет чисел, чтобы осуществлять проверку на окончание ввода
// проверять, больше ли число 0? если да — считать 

int CountNumbersBiggerThanZero(int value)
{
    int count = 0;
    for (int i = 0; i < value; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Укажите количество вводимых чисел:  ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество чисел больше нуля: {CountNumbersBiggerThanZero(M)}");


// int i = 0;
// int count = 0;
// while (i < M)
// {
//     Console.WriteLine($"Введите {i + 1} число: ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     if (N > 0)
//     {
//         count++;
//     }
//     i++;
// }

// Console.WriteLine($"Количество чисел больше нуля: {count}");


// for (int i = 0; i < M; i++)
// {
//     Console.WriteLine($"Введите {i + 1} число: ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     if (N > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество чисел больше нуля: {CountNumbersBiggerThanZero(M)}");
