//Ejercicio 1
Console.WriteLine("Ejercicio 1");
for (int i1 = 1; i1 <= 5; i1++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write("1");
    }
    Console.WriteLine();
}

//Ejercicio 2
Console.WriteLine("Ejercicio 2");
for (int i2 = 1; i2 <= 4; i2++)
{
    for (int j = 1; j <= 6; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Ejercicio 3
Console.WriteLine("Ejercicio 3");
for (int i3 = 1; i3 <= 5; i3++)
{
    for (int j = 1; j <= i3; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Ejercicio 4
Console.WriteLine("Ejercicio 4");
for (int i4 = 5; i4 >= 1; i4--)
{
    for (int j = 1; j <= i4; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Ejercicio 5
Console.WriteLine("Ejercicio 5");
for (int i5 = 1; i5 <= 5; i5++)
{
    for (int j = 1; j <= 12; j++)
    {
        Console.WriteLine(i5 + " x " + j + " = " + (i5*j));
    }
    Console.WriteLine();
}

//Ejercicio 6
Console.WriteLine("Ejercicio 6");
int contador = 1;
for (int i6 = 1; i6 <= 3; i6++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.Write(contador);
        contador++;
    }
    Console.WriteLine();
}

//Ejercicio 7
Console.WriteLine("Ejercicio 7");
for (int i7 = 1; i7 <= 3; i7++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine(i7 + " - " + j);

    }
}

//Ejercicio 8
Console.WriteLine("Ejercicio 8");
for (int i8 = 1; i8 <= 4; i8++)
{
    for (int j = 1; j <= 4; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}

//Ejercicio 9
Console.WriteLine("Ejercicio 9");
for (int i9 = 1; i9 <= 5; i9++) 
{
    for (int j = 1; j <= i9; j++) 
    {
        Console.Write(i9);
    }
    Console.WriteLine();
}

//Ejercicio 10
Console.WriteLine("Ejercicio 10");
for (int i10 = 1; i10 <= 4; i10++)
{
    for (int j = 1; j <= i10; j++)
    {
        Console.Write(i10);
    }
    Console.WriteLine();
}

//Ejercicio 11
Console.WriteLine("Ejercicio 11");
int i11 = 1;
while (i11 <= 10)
{
    Console.WriteLine(i11);
    i11++;
}

//Ejercicio 12
Console.WriteLine("Ejercicio 12");
int i12 = 10;
while (i12 >= 1)
{
    Console.WriteLine(i12);
    i12--;
}

//Ejercicio 13
Console.WriteLine("Ejercicio 13");
int i13 = 2;
while (i13 <= 20)
{
    Console.WriteLine(i13);
    i13 += 2;
}

//Ejercicio 14
Console.WriteLine("Ejercicio 14");
int i14 = 1;
while (i14 <= 20)
{
    Console.WriteLine(i14);
    i14 += 2;
}

//Ejercicio 15
Console.WriteLine("Ejercicio 15");
int i15 = 1;
int suma = 0;
while (i15 <= 100)
{
    suma += i15;
    i15++;
}
Console.WriteLine("La suma es: " + suma);

//Ejercicio 16
Console.WriteLine("Ejercicio 16");
int i16 = 1;
while (i16 != 0)
{
    Console.WriteLine("Ingrese numero: ");
    int j = int.Parse(Console.ReadLine());
    i16 = j;
}

//Ejercicio 17
Console.WriteLine("Ejercicio 17");
int i17 = 1;
int positivos = 0;
while (i17 != 0)
{
    Console.WriteLine("Ingrese numero: ");
    i17 = int.Parse(Console.ReadLine());

    if (i17 > 0)
    {
        positivos++;
    }
}
Console.WriteLine(positivos);

//Ejercicio 18
Console.WriteLine("Ejercicio 18");
Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());
int factorial = 1;
int i18 = 1;
while (i18 <= numero)
{
    factorial *= i18;
    i18++;
}
Console.WriteLine("El factorial es: " + factorial);

//Ejercicio 19
Console.WriteLine("Ejercicio 19");
Console.Write("Ingresa un número: ");
int numero1 = int.Parse(Console.ReadLine());
int i19 = 1;
while (i19 <= 10)
{
    Console.WriteLine(numero1 + " x " + i19 + " = " + (numero1 * i19));
    i19++;
}

//Ejercicio 20
Console.WriteLine("Ejercicio 20");
Console.WriteLine("ingrese numero");
int numerodos = int.Parse(Console.ReadLine());
int digitos = 0;
while (numerodos > 0)
{
    numerodos = numerodos / 10;
    digitos++;
}
Console.WriteLine("El numero tiene " + digitos + " digitos.");