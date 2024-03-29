using System;

namespace Table20
{
    public class Table20
    {
        public static void Main()
        {
            int num;

            Console.Write("\n\n");
            Console.Write("Input the desired number : ");
            num = Convert.ToInt32(Console.ReadLine());
            table(num);
        }
        public static void table(int num)
        {
            Console.WriteLine("\nDisplay the multiplication table");
            Console.WriteLine("-----------------------------------");
            for (int j = 1; j <= 20; j++)
            {
                Console.WriteLine("{0} X {1} = {2} ", num, j, num * j);
            }
        }
    }
}