using System;

namespace addNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(addnum(5));
            Console.Read();
        }
        static int addnum(int num){
            int j = 0;
            int i = 0;
            int k = num;
            while (i <= k)
            {
                j += num--;
                i++;
            }
            return j;
        }
    }
}
