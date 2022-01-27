using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы");
            int m = int.Parse(Console.ReadLine());

            Material_Matrix matrix = new Material_Matrix(n, m);
            Random rnd = new Random();
            //Заполняем матрицу (по столбцам), в пределах одного столбца значения не повторяются
            Console.WriteLine("Матрица:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(-5, 10);

                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----Операция ++-------");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j]++;
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сдвиг столбцов ");


            float[] temp = new float[m];
            List<int> list = new List<int>();
            int k1;
            double max0, iMax0 = -1;
            double max, iMax = -2, jMax = -1;


            max0 = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                if (matrix[i, 0] > max0)
                {
                    max0 = matrix[i, 0];
                    iMax0 = i;
                }
            }

            int j2 = 0;
            for (int j = 1; j < n; j++)
            {

                max = int.MinValue;
                for (int i = 0; i < m; i++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }

                if (iMax == iMax0)
                {
                    j2++;
                    while (jMax > j2)
                    {
                        for (k1 = 0; k1 < m; k1++)
                        {
                            temp[k1] = matrix[k1, j2];
                        }

                        for (k1 = j2; k1 < n - 1; k1++)
                        {
                            for (int i = 0; i < m; i++)
                            {
                                matrix[i, k1] = matrix[i, k1 + 1];
                            }
                        }

                        for (k1 = 0; k1 < m; k1++)
                        {
                            matrix[k1, n - 1] = temp[k1];
                        }
                        jMax--;
                    }
                    j = j2 + 1;
                }
            }

            Console.WriteLine("Результат:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}


