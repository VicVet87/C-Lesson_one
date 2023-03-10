/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.*/

string[] strarr = {"hello", "2", "world", ":-)"};
//string[] strarr = {"1234", "1567", "-2", "computer science"};
//string[] strarr = {"Russia", "Denmark", "Kazan"};
int count = 0; //кол=во значений в исходном массиве длина которых меньше либо равна 3

for (int i = 0; i < strarr.GetLength(0); i++)
{
    if(strarr[i].Length < 4)
        count++;
}
if (count>0)
{
    string[] resultarr = new string[count];
int index = 0; //индекс результирующего массива

for (int i = 0; i < strarr.GetLength(0); i++)
{
    if(strarr[i].Length < 4)
    {
        resultarr[index] = strarr[i];
        index++;
    }
}
string temp = "[";
for (int i = 0; i < resultarr.GetLength(0); i++)
{
    temp += "\"" + resultarr[i] + "\", ";
    
}
temp = temp.Substring(0, temp.Length -2) +"]";
Console.Write(temp);
}
else Console.Write("[]");

