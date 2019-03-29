using System;

public class C1
{
        public static void Main(String[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 5; j > i; j--)
                {
                    Console.Write("@");
                }
            Console.Write("\n");
            }
        }
}
