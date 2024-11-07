﻿﻿using System;
public class TablaMultiplicar
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("{0}x{1}= {2}", x, i, x * i);
        }
        Console.ReadKey();
    }
}

/*
 * Escribe un programa en C# que pregunte al usuario por un número x y muestre el resultado de su tabla de multiplicar del 1 al 10.
 * */

/*
Optimización:

    Se utiliza un solo Console.WriteLine con interpolación de cadenas para mostrar el resultado.
    Las condiciones se agrupan usando el operador ternario ? : para simplificar la estructura y reducir la cantidad de líneas.
    El código sigue siendo legible pero más compacto y eficiente.
*/
