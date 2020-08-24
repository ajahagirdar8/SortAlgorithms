using System;
using System.Collections.Generic;

namespace SelectionSort
{
	public class Selection
	{
		public static IComparable[] sort(IComparable[] a)
		{
			int N = a.Length;

			for (int i = 0; i < N-1; i++) {

				int min = i;
				
				for (int j = i + 1; j < N; j++) {

					if(less(a[j],a[min]))
						min = j;

					exchange (a, i, min);
				}
			}

			return a;

		}

		private static bool less(IComparable u, IComparable v)
		{
			return u.CompareTo (v) < 0;
		}

		private static void exchange(IComparable[] a, int i, int j)
		{
			IComparable tmp = a [i];
			a [i] = a [j];
			a [j] = tmp;
		}
	}
}

