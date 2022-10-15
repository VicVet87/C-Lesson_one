/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int a,b,c,max;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
c = Convert.ToInt32(Console.ReadLine());
max = a;
if(a < b)
    max = b;
if(max < c)
    max = c;
Console.WriteLine(max);