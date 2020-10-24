using System;

namespace CountingValleys
{
    class Program
    {
        public static int CountingValleys(int steps, string path)
        {
            var value = path.ToCharArray();

            int Up = 0;

            int Down = 0;

            int Mountains = 0;

            int Valley = 0;

            for (int i = 0; i < steps; i++)
            {
                if (value[i] == 'U')
                {
                    Up++;
                }
                if (value[i] == 'D')
                {
                    Down++;
                }
                if (Up == Down)
                {
                    if(value[i] == 'U')
                    {
                        Valley++;
                    }

                    else if (value[i] == 'D')
                    {
                        Mountains++;
                    }
                }
            }

            return Valley;            
        }

        static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = CountingValleys(steps, path);

            Console.WriteLine(result);
        }
    }
}
