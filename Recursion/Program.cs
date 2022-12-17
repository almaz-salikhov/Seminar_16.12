int get_factorial(int x)
{
    if(x == 1)
    {
        return 1;
    }
    else
    {
        int res = get_factorial(x - 1); // переменна для рекурсивного вызова
        Console.WriteLine(res);
        return x * res; 
    }   
}

get_factorial(5);

