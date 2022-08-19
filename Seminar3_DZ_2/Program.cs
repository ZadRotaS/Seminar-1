using System;
class GFG

{
    
static void distance(double x1, double y1,
                     double z1, double x2,
                     double y2, double z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.Write("Дистанция между точками: " + d);
    return;
}
 
public static void Main()
{
    Console.Write("Введите 1 координату "); double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите 2 координату "); double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите 3 координату "); double z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите 4 координату "); double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите 5 координату "); double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите 6 координату "); double z2 = Convert.ToDouble(Console.ReadLine());
     
    distance(x1, y1, z1,
          x2, y2, z2);
}
}
