/* Case 4
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Enter number A= ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number B= ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number C= ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max;
if(numberA > numberB)
{   
    if(numberA > numberC)
    {
    max = numberA;
    Console.WriteLine($"{numberA} > {numberB}; {numberC} -> A - max number");
    }
}
if(numberB > numberA)
{   
    if(numberB > numberC)
    {
    max = numberB;
    Console.WriteLine($"{numberB} > {numberA}; {numberC} -> B - max number");
    }
}

if(numberC > numberB)
{   
    if(numberC > numberA)
    {
    max = numberC;
    Console.WriteLine($"{numberC} > {numberA}; {numberB} -> C - max number");
    }
}

// Денис, можете на семинаре 3 в субботу 19.11.22 обяснить по подробнее, про функцию Void, не совсем понял, хотя и пересматривал семинар