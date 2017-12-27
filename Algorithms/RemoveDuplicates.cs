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
            int[] arr = { 1, 1,2,2,3,4,4,4,5,5,6,7,8};
            int m = RemoveDuplacates(arr);
            Console.WriteLine(m);
        }


        public static int RemoveDuplacates(int[] arr)
        {
//------------------------------------------------------------First
            //int m = arr.Select(x => x).Distinct().ToArray().Length;
            //return m;
//------------------------------------------------------------Second
         //if (arr.Length == 0)
            //    return 0;
            //int j = 0;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] != arr[j])
            //        arr[++j] = arr[i];
            //}
            //return ++j;
//---------------------------------------------------------------- Third
            int j = 0;
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[j] != arr[i])
                    count++;

                j++;
            }
            return ++count;
        }

        public static void Show(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
