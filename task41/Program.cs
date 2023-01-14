// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] Array()
{
    Console.Write($"Введите длину массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[m];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int[] array = Array();

int Kol(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > 0) count++;
    }
    return count;
}

void Print()
{
    Console.WriteLine();
    Console.WriteLine($"Количество чисел больше нуля: {Kol(array)}");
}

Kol(array);
Print();