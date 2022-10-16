using System;

namespace QuickSort;
class Program
 {

	static void swap(int[] numbers, int i, int j)
	{
		int temp = numbers[i];
		numbers[i] = numbers[j];
		numbers[j] = temp;
	}
	static int partition(int[] numbers, int low, int high)
	{

		// pivot
		int pivot = numbers[high];
		int i = (low - 1);
		for (int j = low; j <= high - 1; j++)
        {
			if (numbers[j] < pivot) 
            {
				i++;
				swap(numbers, i, j);
			}
		}
		swap(numbers, i + 1, high);
		return (i + 1);
	}
	static void quickSort(int[] numbers, int low, int high)
	{
		if (low < high)
        {
			int pi = partition(numbers, low, high);
			quickSort(numbers, low, pi - 1);
			quickSort(numbers, pi + 1, high);
		}
	}
	static void printnumbersay(int[] numbers, int size)
	{
		for (int i = 0; i < size; i++)
			Console.Write(numbers[i] + " ");

		Console.WriteLine();
	}
	public static void Main()
	{
		int[] numbers = { 18,19,1,5,7,3,20};
		int n = numbers.Length;

		quickSort(numbers, 0, n - 1);
		Console.Write("Sorted numbersay: ");
		printnumbersay(numbers, n);
	}
}
