Console.Write("Введите число: "); int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N + "-> ");
for (int i=1; i < N + 1; i++)
{
    int n = i * i * i;
    Console.Write(n + ",");
}
