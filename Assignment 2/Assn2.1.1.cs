using System;

public class C2
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter value");
		int num = int.Parse(Console.ReadLine());
		for(int i = 0; i < num; i++)
            {
                for(int j = num; j > i; j--)
                {
                    Console.Write("@");
                }
            Console.Write("\n");
            }
	}
}