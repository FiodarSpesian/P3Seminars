/* Задача 2 :
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/
Console.Write("Enter number A= ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number B= ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"{numberA} > {numberB} -> A - max number");
}
else if(numberA == numberB)
{
Console.WriteLine($" Error: {numberA} = {numberB}. You must to enter 2 diffirent numbers, use <dotnet run> again.");
}
else 
{
    Console.WriteLine($"{numberA} < {numberB} -> B - max namber");
}

