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
    string[] namesTesk = {  "Задача 1. Упорядочить по убыванию элементы каждой строки двумерного массива",
                            "Задача 2. Находить строку с наименьшей суммой элементов",
                            "Задача 3. Находить произведение двух матриц",
                            "Задача 4. Построчно выводить массив, добавляя индексы каждого элемента",
                            "Задача 5. Заполнит спирально массив N на N" };
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
        static int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
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
    if (x == 4)
    {
        void FillIntArray3(int[,,] mast, int min, int max)
        {
            for (int n = 0; n < mast.GetLength(0); n++)
            {
                for (int i = 0; i < mast.GetLength(1); i++)
                {
                    for (int j = 0; j < mast.GetLength(2); j++)
                    {
                        mast[n, i, j] = new Random().Next(min, max);
                    }
                }
            }
        }
        int[,,] array = new int[2, 2, 2];
        FillIntArray3(array, 1, 100);
        for (int n = 0; n < array.GetLength(0); n++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(2); j++)
                {
                    Console.Write($"{array[n, i, j]} ({n},{i},{j}) ");
                }
                Console.WriteLine();
            }

        }

    }
    if (x == 5)
    {
        Console.Write("Введите число N: "); int N = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, N]; array[0,0] = 1;
        int IndexA = 0, IndexB = 0, m = 2;
        for (int h = 0; h < (array.GetLength(1) + 1) / 2; h++)
        {
            for (int j = 1; j < array.GetLength(0) - IndexB; j++, m++)
            {
                array[IndexA, j] = m;
            }
            IndexB++;
            for (int i = IndexB; i < array.GetLength(1) - IndexB; i++, m++)
            {
                array[i, array.GetLength(1) - 1 - IndexA] = m;
            }

            for (int n = array.GetLength(0) - 1 - IndexA; n >= IndexB; n--, m++)
            {
                array[array.GetLength(1) - 1 - IndexA, n] = m;
            }
            IndexA++;
            for (int k = array.GetLength(1) - IndexB; k >= IndexB; k--, m++)
            {
                array[k, IndexB - 1] = m;
            }
        }
        if (array.GetLength(1) % 2 != 0) { m--; array[array.GetLength(0) / 2, array.GetLength(1) / 2] = m; }
        void PrintIntArray2(int[,] mast)
        {
            for (int i = 0; i < mast.GetLength(0); i++)
            {
                for (int j = 0; j < mast.GetLength(1); j++)
                {
                    if (mast[i,j] < 10)
                    {
                        Console.Write($"0{mast[i, j]}" + " ");
                    }
                    else Console.Write($"{mast[i,j]} ");
                }
                Console.WriteLine();
            }
        
        }
        PrintIntArray2(array);
    }
    Console.WriteLine();
    Console.Write("Для завершения введите (q) для продолжение любой другой символ: ");
    Text = Convert.ToString(Console.ReadLine());
}