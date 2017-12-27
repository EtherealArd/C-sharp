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
            int[] arr = { 4, 5, 3, 2, 7, 6,1 };
            int[] rez = TwoSum(arr, 12);
            for (int i = 0; i < rez.Length; i++)
            {
                Console.WriteLine(rez[i]);
            }
        }

        public static int[] TwoSum(int[] arr,int target)
        {
            int[] m = new int[2];
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dic.ContainsValue(target - arr[i]))
                {
                    dic.Add(i, arr[i]);
                }
                else
                {
                    m[0] = arr[i];
                    m[1] = target - arr[i];
                    break;
                }
            }
            return m;

        }
    }
}
