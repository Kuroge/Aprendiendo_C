﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class ClasMatrices
    {
        private int[,] matriz;

        public ClasMatrices()
        {
            matriz = new int[4, 2];
        }

        public void InicializaMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz[i, j] = 1;
                }
            }
        }
        public void ImprimeMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matriz[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
