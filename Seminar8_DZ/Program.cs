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
void PrintFloatArray(float[,] mast) // Вывести моссив в консоль
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
void PrintIntArray(int[,] mast) // Вывести моссив в консоль
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
void FillFloatArray(float[,] mast, int min, int max) // Заполнить моссив случайными числами от Х до Y
{
    for (int i = 0; i < mast.GetLength(0); i++)
    {
        for (int j = 0; j < mast.GetLength(1); j++)
        {
            mast[i, j] = new Random().Next(min, max);
        }

    }
}
void PrintIntArray1(int[] mast) // Вывести моссив в консоль
{
    for (int i = 0; i < mast.GetLength(0); i++)
    {
        Console.Write($"{mast[i]}" + " ");
    }
}
void FillIntArray(int[,] mast, int min, int max) // Заполнить моссив случайными числами от Х до Y
{
    for (int i = 0; i < mast.GetLength(0); i++)
    {
        for (int j = 0; j < mast.GetLength(1); j++)
        {
            mast[i, j] = new Random().Next(min, max);
        }

    }
}
float[,] NewFloatArray() // Создание двумерного масива
{
    Console.Write("Введите количество строк: "); int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество стобцов: "); int y = Convert.ToInt32(Console.ReadLine());
    float[,] mast = new float[m, y];
    return mast;
}
int[,] NewIntArray()
{
    Console.Write("Введите количество строк: "); int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество стобцов: "); int y = Convert.ToInt32(Console.ReadLine());
    int[,] mast = new int[m, y];
    return mast;
}
//void PrintArray1(int[] mast) // Вывести моссив в консоль
//{
// for (int i = 0; i < mast.Length; i++)
//  {
//      Console.Write(mast[i] + " ");
//   }
//  Console.WriteLine();
//}
string Text = string.Empty;

while (Text != "q")
{
    Console.Clear();
    SelectTesk();

    if (x == 1)
    {
        int[,] array = NewIntArray();
        FillIntArray(array, 1, 10);

        PrintIntArray(array);
        Console.WriteLine();
        int max = 0;

        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] < array[i, j + 1])
                    {
                        max = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = max;

                    }
                }
            }
        }
        PrintIntArray(array);
    }
    if (x == 2)
    {
        int[,] array = NewIntArray();
        FillIntArray(array, 1, 10);
        PrintIntArray(array);
        int[] arrayMin = new int[array.GetLength(0)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arrayMin[i] += array[i, j];
            }
        }
        int min = arrayMin[0];
        for (int i = 1; i < arrayMin.Length; i++)
        {
            if (arrayMin[i] < min)
            {
                min = arrayMin[i];
            }
        }
        PrintIntArray1(arrayMin);
        Console.Write("Строка с наименьшей суммой элементов: ");
        for (int i = 0; i < arrayMin.Length; i++)
        {
            if (min == arrayMin[i]) { Console.Write((i + 1) + " "); }
        }
    }
    if (x == 3)
    {
        static int[,] MatrixProduct(int[,] matrixA,int[,] matrixB)
        {

            int aRows = matrixA.GetLength(0); int aCols = matrixA.GetLength(1);
            int bRows = matrixB.GetLength(0); int bCols = matrixB.GetLength(1);
            int[,] result = new int[aRows, bCols];
            if (aCols != bRows)

                throw new Exception("Non-conformable matrices in MatrixProduct");
            for (int i = 0; i < aRows; ++i)
                for (int j = 0; j < bCols; ++j)
                    for (int k = 0; k < aCols; ++k)
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
            return result;
        }
        int[,] array1 = { { 2, 4 }, { 3, 2 } };
        int[,] array2 = { { 3, 4 }, { 3, 3 } };
        int[,] array3 = MatrixProduct(array1, array2);
        PrintIntArray(array1); PrintIntArray(array2); PrintIntArray(array3);
    }

    Console.WriteLine();
    Console.Write("Для завершения введите (q) для продолжение любой другой символ: ");
    Text = Convert.ToString(Console.ReadLine());
}