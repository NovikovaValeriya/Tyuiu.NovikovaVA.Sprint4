﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NovikovaVA.Sprint4.Task4.V25.Lib
{
    public class DataService : ISprint4Task4V25
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int c = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        c += matrix[i,j];
                    }
                }
            }
            return c;
        }
    }
}
