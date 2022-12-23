Random rnd = new Random();
// 1) 
double d1 = rnd.Next() + rnd.NextDouble(); // находим вещественное 
Console.WriteLine(d1); 

// 2)
int multiplyer = 50;
double d2 = rnd.NextDouble() * multiplyer;

Console.WriteLine(Math.Round(d2, 2)); // округление, в скобку — до скольких знаков; точность 

// 3)
double d3 = rnd.Next() / 100.0;
// rnd.Next 0 .... 2 400 000 000
Console.WriteLine(Math.Round(d3, 2)); 

// 4)
// Также можно сгенерировать целое
// и если оно четное — делить на 3
// если нечетное - делить на 2