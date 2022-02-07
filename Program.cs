using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Data;

namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = 229;

            Console.WriteLine(Kata. Factorial(n));

        }


    }





    public static class Kata
    {
        public static string Factorial(int n)
        {

            //decimal res = 1;
            //decimal res2 = 1;
            //for ( int i = 1; i <= n; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1

            //{
            //    if (res < decimal.MaxValue - 1)
            //    {

            //        res *= i;
            //    }
            //    if (res > decimal.MaxValue-1)
            //    {

            //        res2 *= i;
            //    }
            //}

            String result = String.Join(Environment.NewLine,Enumerable.Range(1, n).Reverse().Select((index) =>String.Format("Factorial of {0}! = {1}\n",index,Enumerable.Range(1, index).Aggregate(1, (p, item) => p * item))));


            return result;
        }
       

    }
}




    