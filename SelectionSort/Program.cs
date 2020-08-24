using System;

namespace SelectionSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			IComparable[] arr = new IComparable[5];
			arr [0] = 4;
			arr [1] = 2;
			arr [2] = 1;
			arr [3] = 5;
			arr [4] = 3;

			//IComparable[] newArr =	Selection.sort (arr);

			IComparable[] newArr = Insertion.sort (arr);

			foreach (int i in newArr) {

				Console.WriteLine (i);
			}
		}
	}
}
