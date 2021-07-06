using System;

namespace C__practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("さいころの目を入力");
            int dice = int.Parse(Console.ReadLine());
            switch (dice)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("丁です");
                    break;
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("半です");
                    break;
                default:
                    Console.WriteLine("不適切な値です");
                    break;

            }
        }
    }
}
