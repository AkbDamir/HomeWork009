/*Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

static uint Akk(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akk(n - 1, 1);
    else
      return Akk(n - 1, Akk(n, m - 1));
}
uint res;
res = Akk(3, 2);
Console.WriteLine(res);