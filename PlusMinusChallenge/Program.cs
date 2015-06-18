using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinusChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int posNum = 0;
            int negNum = 0;
            int zeroNum = 0;
            int[] arr = { 0, 0, -1, 1, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    negNum += 1;
                else if (arr[i] > 0)
                    posNum += 1;
                else if (arr[i] == 0)
                    zeroNum += 1;
            }
            //Math.Round()
            float di = (float)posNum / (float)N;
            float di2 = (float)negNum / (float)N;
            float di3 = (float)zeroNum / (float)N;

            Console.WriteLine(Math.Round(di, 3));
            Console.WriteLine(Math.Round(di2, 3));
            Console.WriteLine(Math.Round(di3, 3));
        }
    }
}
