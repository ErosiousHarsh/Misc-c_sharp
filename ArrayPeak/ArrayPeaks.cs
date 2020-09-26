using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPeak
{
	class ArrayPeaks
	{

		static int findPeakUtil(int[] arr, int low,
								int high, int n)
		{
			// Find index of 
			// middle element 
			int mid = low + (high - low) / 2;

			// Compare middle element with 
			// its neighbours (if neighbours 
			// exist) 
			if ((mid == 0 || arr[mid - 1] <= arr[mid]) && (mid == n - 1 || arr[mid + 1] <= arr[mid]))
				return mid;

			// If middle element is not 
			// peak and its left neighbor 
			// is greater than it, then 
			// left half must have a 
			// peak element 
			else if (mid > 0 && arr[mid - 1] > arr[mid])
				return findPeakUtil(arr, low,
									(mid - 1), n);

			// If middle element is not 
			// peak and its right neighbor 
			// is greater than it, then 
			// right half must have a peak 
			// element 
			else
				return findPeakUtil(arr, (mid + 1),
									high, n);
		}

		// A wrapper over recursive 
		// function findPeakUtil() 
		static int findPeak(int[] arr,
							int n)
		{
			return findPeakUtil(arr, 0,
								n - 1, n);
		}

		// Driver Code 
		static public void Main()
		{
			int[] arr = { 10, 20, 15, 2, 23, 90, 67 };
			int n = arr.Length;
			Console.WriteLine("Index of a peak "
							+ "point is " + findPeak(arr, n));

			Console.ReadLine();
		}
	}

	// This code is contributed by ajit 

}
