using System;

namespace arrays_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] myarrays = new int[] { 1, 1, 2, 3, 5, 8 };
            foreach(int mynumbers in myarrays)
            {
                Console.WriteLine(mynumbers);

            }
            Console.ReadLine();
        }
    }
}
