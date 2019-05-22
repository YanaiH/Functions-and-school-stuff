using System;

namespace functionsSchoolStuff
{
    class Program
    {
        static void Main(string[] args) // just for testing the IsEachNumOnce function
        {
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8 };
            if (MyMath.IsEachNumOnce(test))
            {
                Console.WriteLine("works");
            }
            else
            {
                Console.WriteLine("doesnt");
            }
            Console.ReadKey();
        }

    }
}
