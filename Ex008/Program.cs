/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
int a;
int i = 2; 
string result = "";
Console.WriteLine("Введите число 1");
a = Convert.ToInt32(Console.ReadLine());
while (i <= a)
{
    if(i%2 == 0)
    result += i + ",";
    i++;
}
Console.WriteLine(result.Substring(0, result.Length - 1));
