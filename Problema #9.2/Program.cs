﻿using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            // Verificar si el número es par o divisible entre 3
            if (i % 2 == 0 || i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
