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
    string[] namesTesk = {  "Задача 1. Все натуральные числа в промежутке от M до N",
                            "Задача 2. Сумма натуральных элементов в промежутке от M до N",
                            "Задача 3. Вычисление функции Аккермана",
                            };
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

string Text = string.Empty;

while (Text != "q")
{
    Console.Clear();
    SelectTesk();

    if (x == 1)
    {
        Console.Write("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int j = 0; Console.Write($"M = {M};N = {N}.-> ");
        for (int i = M; i <= N; i++)
        {
            j = i;

            if (i == N) { Console.Write($"{i}."); }
            else Console.Write($"{i}, ");
        }
    }
    if (x == 2)
    {
        Console.Write("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int j = 0; Console.Write($"M = {M};N = {N}.");
        for (int i = M; i <= N; i++)
        {
            j += i;

           // if (i == N) { Console.Write($"{i}"); }
            //else Console.Write($"{i}, ");
        }
        
        Console.WriteLine($"-> {j}");
    }
    if (x == 3)
    {
        int ack(int n, int m)
        {
            if (n == 0)
            {
                return m + 1;
            }
            else if ((n > 0) && (m == 0))
            {
                return ack(n - 1, 1);
            }
            else if ((n > 0) && (m > 0))
            {
                return ack(n - 1, ack(n, m - 1));
            }
            else
                return n + 1;
        }
        Console.Write("Введите чесло m: "); int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите чесло n: "); int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ack(n, m));
    }

    Console.WriteLine();
    Console.Write("Для завершения введите (q) для продолжение любой другой символ: ");
    Text = Convert.ToString(Console.ReadLine());


}