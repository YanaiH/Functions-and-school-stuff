using System;

namespace functionsSchoolStuff
{
    class Program
    {
        static void Main1(string[] args) // just for testing the IsEachNumOnce function
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

        static void Main2() // just for experimenting
        {
            FatBoye[] fatBoyes = new FatBoye[3];
            for (int i = 0; i < fatBoyes.Length; i++)
            {
                fatBoyes[i] = new FatBoye();
                fatBoyes[i].SetFat(true);
                Console.WriteLine(fatBoyes[i].Name());
            }
            Console.ReadKey();
        }

        static void Main() // dumb stuff for jumper class
        {
            Console.Write("Enter jumper's name: ");
            string name = Console.ReadLine();
            double[] jumps = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter jump height: ");
                jumps[i] = double.Parse(Console.ReadLine());
            }
            Jumper test = new Jumper(name, jumps);
            test.PrintJumper();
            Console.ReadKey();
        }
    }
}
