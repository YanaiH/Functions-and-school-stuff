using System;

namespace functionsSchoolStuff
{
    class Jumper
    {
        private string name;
        private double[] jumps;

        public Jumper(string name, double[] jumps)
        {
            if (name.Length > 0)
            {
                this.name = name;
            }
            if (jumps.Length == 5)
            {
                this.jumps = jumps;
            }
        }

        public void PrintJumper()
        {
            double highest = 0;
            for (int i = 0; i < 5; i++)
            {
                if (jumps[i] > highest)
                {
                    highest = jumps[i];
                }
            }
            Console.WriteLine("Name: " + name + ", highest jump: " + highest);
        }
    }
}
