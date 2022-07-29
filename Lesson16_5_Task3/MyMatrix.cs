using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_5_Task3
{
    internal class MyMatrix
    {
        private int[,] matrix;
        private int columns, rows;

        public int this[int i, int j]
        {
            get
            {
                return matrix[i,j];
            }
            set
            {
                matrix[i,j] = value;
            }
        }
        public MyMatrix(int Columns, int Rows)
        {
            if (Columns <= 0 || Rows <= 0)
            {
                Console.WriteLine("Values must be >0. Array not created.");
            }
            else
            {
                this.columns = Columns;
                this.rows = Rows;
                matrix = new int[Columns, Rows];
            }
        }
        public void ChangeSize(int Columns, int Rows)
        {
            if (Columns <= 0 || Rows <= 0)
            {
                Console.WriteLine("Values must be >0. Array not changed.");
            }
            else
            {
                this.columns = Columns;
                this.rows = Rows;
                matrix = new int[Columns, Rows];
            }
        }
        public void RandomFill()
        {
            Random random = new Random();

            for (int i = 0; i < this.columns; i++)
            {
                for (int j = 0; j < this.rows; j++)
                {
                    matrix[i, j] = random.Next(0, 9);
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < this.columns; i++)
            {
                for (int j = 0; j < this.rows; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.Write('\n');
            }

        }
    }
}
