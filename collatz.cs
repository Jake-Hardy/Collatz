using System;

class Collatz
{
	static void Main(string[] args) 
	{
		int startingNum = Int32.Parse(args[0]);
		int count = 0;
		
		Console.WriteLine("Starting Collatz test with " + args[0]);
		
		while (startingNum != 1)
		{
			if (startingNum % 2 == 0) 
			{
				Console.WriteLine(startingNum + " / 2 = " + startingNum/2);
				startingNum /= 2;
				count++;
			}
			else 
			{
				Console.WriteLine(startingNum + " * 3 + 1 = " + (startingNum * 3 + 1));
				startingNum = startingNum * 3 + 1;
				count++;
			}
		}
		
		Console.WriteLine("Collatz test finished. Took " + count + " iterations to reach 1.");
	}
}
