using System;
using System.Data;
using System.Globalization;
using MyLib;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
        
            void Task47()
            {
                /* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
                m = 3, n = 4.
                0,5 7 -2 -0,2
                1 -3,3 8 -9,9
                8 7,8 -7,1 9 */
                int rows = 5;
                int columns = 6;
                double[,] numbers = new double[rows, columns];

                MyLibClass.FillArray(numbers, -100, 100);
                MyLibClass.PrintArray(numbers);

            }

            void Task50()
            {
                /* Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
                Например, задан массив:
                1 4 7 2
                5 9 2 3
                8 4 2 4

                1, 3 -> 3 */
                int rows = 5;
                int columns = 6;
                double[,] numbers = new double[rows, columns];

                MyLibClass.FillArray(numbers, -100, 100);
                MyLibClass.PrintArray(numbers);

                int inputRow = MyLibClass.Input("Введите строку элемента: ") - 1;
                int inputColumn = MyLibClass.Input("Введите столбец элемента: ") - 1;

                if (inputRow >= 0 && inputRow < rows &&
                    inputColumn >= 0 && inputColumn < columns)
                {
                    Console.WriteLine($"Ваш элемент: {numbers[inputRow, inputColumn]}");
                }
                else
                {
                    Console.WriteLine($"Некорректный ввод");
                }
            }

            void Task52()
            {
                /* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
                Например, задан массив:
                1 4 7 2
                5 9 2 3
                8 4 2 4
                Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
                 */

                int rows = 5;
                int columns = 6;
                int[,] numbers = new int[rows, columns];

                MyLibClass.FillArray(numbers, 0, 9);
                MyLibClass.PrintArray(numbers);
                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                {   
                    double sum = 0;
                    for (int i = 0; i < rows; i++)   
                    {
                        sum += numbers[i, j];
                    }
                    double result = sum/rows;
                    result = Math.Round(result, 2);
                    Console.Write($"{result}\t");
                }

            }

            Console.Clear();
            Task47();

        }
    }
}