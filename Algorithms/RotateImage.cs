using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { 
                { 1, 2, 3,4}, 
                { 5, 6, 7,8 }, 
                { 9, 10, 11,12 },
                { 13, 14, 15,16 },
            };

          int[,]a =   RotateImage(arr);
            Show(a);
        }

        public static int[,] RotateImage(int[,] arr)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

         for (int i=0;i<arr.GetLength(0);i++)
         {
                for (int j = i; j < arr.GetLength(1); j++)
                {
                    int temp = 0;
                   temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;
                }

                
            }
            Show(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) / 2; j++)
                {
                    int temp = 0;
                    temp = arr[i, j];
                    arr[i, j] = arr[i, arr.GetLength(0) - 1 - j];
                    arr[i, arr.GetLength(0) - 1 - j] = temp;
                }
            }


            return arr;
        }
        public static void Show(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
            }
        }
    }
}
