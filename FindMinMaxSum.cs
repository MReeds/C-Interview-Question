using System;

public class Program
{
	// Instructions: Given a collection of integers, write a method that will output the min, max and sum without using Linq
	//	An initial collection of data and a stab of the method has been provided below.
	//  Make sure to consider collections with different numbers of elements and in different orders.

	private static readonly int[] InitialCollection = { 1, 2, 3, 4, 5 };

	public static void Main()
	{
		FindMinMaxSum(InitialCollection);
	}

	private static void FindMinMaxSum(int[] collection)
	{

		if (collection.Length == 0)
		{
			Console.WriteLine("Must provide a list of numbers");
		}
		else
		{
			var sum = 0;
			var min = collection[0];
			var max = collection[0];

			for (var i = 0; i < collection.Length; i++)
			{
				if (collection[i] < min)
				{
					min = collection[i];
				}
				if (collection[i] > max)
				{
					max = collection[i];
				}
				sum += collection[i];
			}

			Console.WriteLine($"Min: {min}, Max: {max}, Sum: {sum}");
		}
	}
}