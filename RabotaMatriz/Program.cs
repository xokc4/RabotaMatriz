using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("чтобы умножить матрицу напишите 1, чтобы сложить 2  матрицы напишите 2, чтобы вычесть 2 матрицы напишите 3, чтобы умножить матрицу на матрицу напишите 4.");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)//условие работы методов
            {
                case 1:
                    MatriaUmnowenie();
                    break;
                case 2:
                    MatrizSlowenie();
                    break;
                case 3:
                    MatrizFi4itanie();
                    break;
                case 4:
                    Umnowenie2Matriz();
                    break;
                default:
                    Console.WriteLine("неправильная цифра");
                    break;
            }


        }
        static void MatriaUmnowenie()
        {
            Console.WriteLine("кол столбцов");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол строк");
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[x, y];
            for (int i = 0; i < x; i++)// создания матрицы
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)// вывод матрицы
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz[i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("напишите число на которое нужно умножить");
            int q = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)// умножение матрицы на число
            {
                for (int j = 0; j < y; j++)
                {
                    matriz[i, j] *= q;
                }
            }
            for (int i = 0; i < x; i++)// вывод новой матрицы
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz[i, j] + "\t");
                }
            }
            Console.ReadKey();
        }// метод по умножение матрицы на число
        static void MatrizSlowenie()
        {
            Console.WriteLine("кол столбцов");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол строк");
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] matriz1 = new int[x, y];
            for (int i = 0; i < x; i++)// создания матрицы 1
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]:");
                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)// вывод матрицы
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz1[i, j] + "\t");
                }
            }
            Console.WriteLine();

            int[,] matriz2 = new int[x, y];
            for (int i = 0; i < x; i++)// создания матрицы 2

            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]:");
                    matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)// вывод матрицы
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz2[i, j] + "\t");
                }
            }
            Console.WriteLine();
            int[,] matriz3 = new int[x, y];
            for (int i = 0; i < x; i++)// новая матрица после сложения
            {
                for (int j = 0; j < y; j++)
                {
                    matriz3[i,j] = matriz1[i,j] + matriz2[i,j];
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz3[i, j] + "\t");
                }
            }
            Console.ReadKey();
        }// метод по сложению двух матриц
        static void MatrizFi4itanie()
        {
            Console.WriteLine("кол столбцов");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол строк");
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] matriz1 = new int[x, y];
            for (int i = 0; i < x; i++)// создания матрицы 1
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]:");
                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)// вывод матрицы
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz1[i, j] + "\t");
                }
            }
            Console.WriteLine();

            int[,] matriz2 = new int[x, y];
            for (int i = 0; i < x; i++)// создания матрицы 2
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]:");
                    matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)// вывод матрицы
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz2[i, j] + "\t");
                }
            }
            Console.WriteLine();
            int[,] matriz3 = new int[x, y];
            for (int i = 0; i < x; i++)// новая матрица после вычитания
            {
                for (int j = 0; j < y; j++)
                {
                    matriz3[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz3[i, j] + "\t");
                }
            }
            Console.ReadKey();
        }// метод по вычетанию двух матриц
        static void Umnowenie2Matriz()
        {
            Console.WriteLine("кол столбцов");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол строк");
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] matriz1 = new int[x, y];
            for (int i = 0; i < x; i++)// создания матрицы 1
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]:");
                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)// вывод матрицы
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz1[i, j] + "\t");
                }
            }
            Console.WriteLine();

            int[,] matriz2 = new int[x, y];
            for (int i = 0; i < x; i++)// создания матрицы 2
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]:");
                    matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)// вывод матрицы
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz2[i, j] + "\t");
                }
            }
            Console.WriteLine();
            int[,] matriz3 = new int[matriz1.Length, matriz2.Length];
            for (int i = 0; i < matriz2.GetLength(1); i++)// новая матрица после умножение 
            {
                for (int j = 0; j < matriz2.GetLength(0); j++)
                {
                    matriz3[i, j] = 0;
                    for (int k = 0; k < matriz2.GetLength(0); k++)
                    {
                        matriz3[i, j] += matriz1[i, k] * matriz2[k, j];
                    }
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("  " + matriz3[i, j] + "\t");
                }
            }
            Console.ReadKey();

        }// метод по умножение двух матриц
    }

}
