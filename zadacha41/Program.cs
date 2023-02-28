// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = Array(size);
int count = 0;

int[] Array(int inputArray)
{
    int[] result = new int[size];
    Console.WriteLine("Введите первое число: ");
    result[0] = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i < size - 1; i++)
    {
        Console.WriteLine("Введите следующее число: ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Введите последнее число: ");
    result[size - 1] = Convert.ToInt32(Console.ReadLine());
    return result;
}

for (int i = 0; i < size; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Пользователь ввёл {count} чисел больше 0");