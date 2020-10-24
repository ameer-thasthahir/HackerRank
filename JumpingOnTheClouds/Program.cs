using System;

namespace JumpingOnTheClouds
{
    class Program
    {

        static int jumpingOnClouds(int[] c)
        {
            int jump = 0;
            bool flg  = false;
            for(int i =0; i< c.Length -1; i++)
            {
                if(c[i] == 1)
                {
                    continue;
                }

                if (c[i+1] == 0)
                {
                    if (flg)
                    {
                        jump++;
                        flg = false;
                    }
                    else
                    {
                        flg = true;
                    }
                }

                if(c[i+1]==1)
                {
                    jump++;
                }                
            }

            return jump+1;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);

            Console.Read();
        }
    }
}
