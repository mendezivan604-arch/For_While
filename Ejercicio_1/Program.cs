//Ejercicio 1
Console.WriteLine("Ejercicio 1");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write("1");
    }
    Console.WriteLine();
}

//Ejercicio 2
Console.WriteLine("Ejercicio 2");
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 6; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Ejercicio 3
Console.WriteLine("Ejercicio 3");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Ejercicio 4
Console.WriteLine("Ejercicio 4");
for (int i = 5; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Ejercicio 5
Console.WriteLine("Ejercicio 5");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 12; j++)
    {
        Console.WriteLine(i + " x " + j + " = " + (i*j));
    }
    Console.WriteLine();
}