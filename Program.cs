﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public static class Program
{





    public static void Main(string[] args)
    {


        int n1, n2, i, j, flag;


        Console.Write(" n1 = ");


        n1 = int.Parse(Console.ReadLine());


        Console.Write(" n2 = ");


        n2 = int.Parse(Console.ReadLine());


        Console.WriteLine("\nPrime numbers between " +
                        "{0} and {1} are: ", n1, n2);


        for (i = n1; i <= n2; i++)
        {


            if (i == 1 || i == 0)
                continue;


            flag = 1;

            for (j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;
                    break;
                }
            }


            if (flag == 1)
                Console.WriteLine("\t" + i);
        }

        Console.ReadLine();
    }
}
