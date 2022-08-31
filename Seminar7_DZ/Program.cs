int x = 0;
void Select(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        Console.WriteLine(i + 1 + " - " + words[i] + ".");
    }
}
void SelectTesk()
{
    string[] namesTesk = { "Задача 1. Двумерный массив заполненный случайными вещественными числами", "Задача 2. Произведение пар чисел в одномерном массиве", "Задача 3. Найти среднее арифметическое элементов в каждом столбце" };
    Console.WriteLine("Задачи:");
    Select(namesTesk);
    Console.Write("Выбери задачу: ");
    x = Convert.ToInt32(Console.ReadLine());

    if (x > namesTesk.Length)
    {
        Console.WriteLine("Вы выбрали задачу которой нету запустите заного и выберите задачу из списка.");
    }
    else
    {
        string TeskHero = namesTesk[x - 1];
        Console.WriteLine("Вы выбрали задачу: " + TeskHero + ".");
    }
}
void PrintArray(float[,] mast) // Вывести моссив в консоль
{
    for (int i = 0; i < mast.GetLength(0); i++)
    {
        for (int j = 0; j < mast.GetLength(1); j++)
        {
            Console.Write($"{mast[i, j]}" + " ");

        }
        Console.WriteLine();
    }
}
void FillArray(float[,] mast, int min, int max) // Заполнить моссив случайными числами от Х до Y
{
    for (int i = 0; i < mast.GetLength(0); i++)
    {
        for (int j = 0; j < mast.GetLength(1); j++)
        {
            mast[i, j] = new Random().Next(min, max);
        }

    }
}
string Text = string.Empty;

while (Text != "end")
{
    Console.Clear();
    SelectTesk();

    if (x == 1)
    {
        Console.Write("Введите количество строк: "); int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество стобцов: "); int y = Convert.ToInt32(Console.ReadLine());
        float[,] array = new float[m, y];
        FillArray(array, -99, 99);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] /= 10;
            }
        }
        PrintArray(array);
    }
    if (x == 2)
    {
        Console.Write("Введите количество строк: "); int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество стобцов: "); int y = Convert.ToInt32(Console.ReadLine());
        float[,] array = new float[m, y];
        FillArray(array, 0, 20);
        PrintArray(array);
        Console.Write("Введите число каторое хотите найти: "); int n = Convert.ToInt32(Console.ReadLine());
        int n1 = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == n)
                {
                    n1++;
                    Console.WriteLine("Число находится в строчке " + (i + 1) + " столбик " + (j + 1));
                }
            }
        }
        if (n1 == 0) { Console.WriteLine(n + "-> такого числа в массиве нет"); }
    }
    if (x == 3)
    {
        Console.Write("Введите количество строк: "); int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество стобцов: "); int y = Convert.ToInt32(Console.ReadLine());
        float[,] array = new float[m, y];
        FillArray(array, 1, 9);
        PrintArray(array);
        float sum = 0;
        Console.Write("Среднее арифметическое каждого столбца: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
            }
            sum = sum / array.GetLength(0);
            Console.Write($"{sum} ");
            sum = 0;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Для завершения введите (end) для продолжение любой другой символ: ");
    Text = Convert.ToString(Console.ReadLine());
}