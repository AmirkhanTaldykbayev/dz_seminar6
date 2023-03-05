//Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Вводим переменную, в которую будем выводить результат
string result = String.Empty;

while (number >= 1)
{
    int temp = number % 2;
    number = number / 2;
    result = Convert.ToString(temp) + result; // Конвертируем в string и добавляем в переменную result
}

Console.WriteLine($"Преобразование в двоичное число: {result}");