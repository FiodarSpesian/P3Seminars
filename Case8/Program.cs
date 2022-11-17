/*Case 8
Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("Enetr number bigger then 0: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int div;
while(count <= N)
{
    div = count % 2;
    if(div == 0)
    {
        Console.Write($"{count}, ");
    }
    count ++;
}
/*
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
*/
    /*if(div == 0)
    Console.Write($"{count}");
    else 
    {
        Console.WriteLine(", ");
    }
    count ++; 
    */
