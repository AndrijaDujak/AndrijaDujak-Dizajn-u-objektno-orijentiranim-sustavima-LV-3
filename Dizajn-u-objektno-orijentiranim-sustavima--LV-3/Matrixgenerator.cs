using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dizajn_u_objektno_orijentiranim_sustavima__LV_3
{
    class Matrixgenerator /*zadatak 2*/
    {
        private static Matrixgenerator instance;
        private Random generator;
        private static int[,] array2D;

        private Matrixgenerator()
        {
            this.generator = new Random();

        }

        public static Matrixgenerator GetInstance(int rows, int columns)
        {
            if (instance == null)
            {
                instance = new Matrixgenerator();
                array2D = new int[rows, columns];
            }
            return instance;
        }
        private void CreateMatrix(int rows, int columns)
        {
            for(int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array2D[j, i] = this.generator.Next(0,1);
                }
            }
        }
    }
}
