/*Задача 66: Задайте значения M и N. 
Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int WriteNumber(int a, int b, int sum =0)
{
    sum += a;
    if (a == b) return sum;
    return WriteNumber(a + 1, b, sum);
}
Console.WriteLine(WriteNumber(4, 8));
