// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//К сожалению я не справился с этой задачей, так как не могу вникнуть в эту тему

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

// double k1 = 5;
// double b1 = 2;
// double k2 = 9;
// double b2 = 4;

// формулу по поиску X-а увидел в чате в телеге у "Vlad Ber"
double x = (b2 - b1) / (k1 - k2);

//Подставил формулу
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

Console.WriteLine(x);
Console.WriteLine($"{y1:f2} ; {y2:f2}");
