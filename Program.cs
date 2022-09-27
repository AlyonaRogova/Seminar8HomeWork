using System;

namespace Seminar8HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            
            int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
                int[,] array = new int[rows,cols];
                for(int i = 0; i<rows; i++)
                    for(int j = 0; j<cols; j++)
                        array[i,j] = new Random().Next(min, max+1);
                return array;
            }

            void Show2dArray(int[,] array){
                for(int i = 0; i<array.GetLength(0); i++){
                    for(int j = 0; j<array.GetLength(1); j++){
                        Console.Write(array[i,j]+ " ");
                    }
                    Console.WriteLine();
                }
            }

            int [,] ReverseRows (int [,] array){
                int temp=0;
                                
                for (int i=0; i<array.GetLength(0); i++){
                    for (int j=0; j<array.GetLength(1); j++){
                        for (int k=0;k<array.GetLength(1)-1;k++){    
                            if(array[i,k] <array[i, k+1]){
                                temp=array[i,k];
                                array[i,k]=array[i, k+1];
                                array[i, k+1]=temp;
                            }
                        }
                    }
                }
                return array;
            }

            Console.Write("Input numb of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input numb of cols: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input numb of min: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input numb of max: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[,] array = CreateRandom2dArray(rows,cols,min,max);
            Show2dArray(array);
            Console.WriteLine();
            int [,] array2 = ReverseRows (array);
            Show2dArray(array2);
        }
    }
}
