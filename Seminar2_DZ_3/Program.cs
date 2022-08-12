int Day = 0;
Console.Write("Введите день недели: ");
Day = Convert.ToInt32(Console.ReadLine());
Console.Write(Day);
if (Day <= 5)
{
    Console.Write("Это рабочий день");
}
else 
{
    Console.Write("Это выходной день");
}