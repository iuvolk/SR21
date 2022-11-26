﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SR21
{
    internal class Program
    {

        const int n = 4;
        const int m = 3;
        static int[,] path = new int[n, m] { { 1, 1,1 }, { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardner2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    {

                        Console.Write($"{path[i,j]} ");
                    }
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }

        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -1;
                        Thread.Sleep(delay);

                    }
                }
            }
        }
        static void Gardner2()
        {

            for (int j = m - 1; j >= 0; j--)
            {
                for (int i = n - 1; i >= 0; i--)

                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -2;
                        Thread.Sleep(delay);

                    }
                }
            }
        }
    }
}
