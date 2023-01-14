// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[2, 3];
array[0, 2] = b1;
array[0, 0] = -k1;
array[1, 2] = b2;
array[1, 0] = -k2;
array[0, 1] = 1;
array[1, 1] = 1;

void Ptint()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void GausFaza()
{
    double t = (array[1, 0] / array[0, 0]) * (-1);

    array[1, 0] = array[0, 0] * t + array[1, 0];
    array[1, 1] = array[0, 1] * t + array[1, 1];
    array[1, 2] = array[0, 2] * t + array[1, 2];
}

void GausRes()
{
    double y = array[1, 2] / array[1, 1];

    double x = (array[0, 2] - y) / array[0, 0];
    Console.Write($"Точка пересечения двух прямых: [{y}], [{x}]");
}
Console.WriteLine($" Матрица Гауса фаза1:");
Ptint();
GausFaza();
Console.WriteLine($" Матрица Гауса фаза2:");
Ptint();
GausRes();
// Округлять десятичные дроби не стал сознательно, так как ответы дробей с периодами, будут округляться. Лучше пусть видят дроби полные