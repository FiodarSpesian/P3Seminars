/* Case6
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Введите любое число: "); 
int numberA = Convert.ToInt32(Console.ReadLine());
int div;
div = numberA % 2 ;
if(div == 0)
{
    Console.WriteLine("Число является четным! "); 
}
else 
{
     Console.WriteLine("Число является НЕчетным! ");  
}