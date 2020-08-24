using System;

namespace SelectionSort
{
	public class Insertion
	{
		public static IComparable[] array;

		public static bool isLess(IComparable u, IComparable v)
		{
			return u.CompareTo (v) < 0;
		}

		public static void exchange(int i, int j)
		{
			IComparable temp = array [i];
			array [i] = array [j];
			array [j] = temp;
		}

		public static IComparable[] sort(IComparable[] items)
		{
			int len = items.Length;
			array = items;

			for (int i = 0; i < len; i++) {

				for (int j = i; j > 0; j--) {

					if (isLess (items [j], items [j - 1])) {
						exchange (j, j - 1);
					} else
						break;
				}
			}

			return array;
		}
	}
}

