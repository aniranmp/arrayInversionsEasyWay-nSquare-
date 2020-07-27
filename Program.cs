using System;

namespace arrayInversionsEasyWay
{
	class Program
	{
		class Pairs
		{
			private int x;
			private int y;
			public void setX(int x)
			{
				this.x = x;
			}
			public void setY(int y)
			{
				this.y = y;
			}
			public int getX()
			{
				return x;
			}
			public int getY()
			{
				return y;
			}
		}
		static int[] arr = new int[] { 1, 20, 6, 4, 5, 31 };
		static Pairs[] pair = new Pairs[arr.Length+1];
		static int getInvCount(int n)
		{
			int inv_count = 0;

			for (int i = 0; i < n - 1; i++)
				for (int j = i + 1; j < n; j++)
					if (arr[i] > arr[j])
					{
						inv_count++;
						pair[inv_count] = new Pairs();
						pair[inv_count].setX(arr[i]);
						pair[inv_count].setY(arr[j]);
						Console.WriteLine("({0},{1})",pair[inv_count].getX(),pair[inv_count].getY());

					}

			return inv_count;
		}

		// Driver code 
		public static void Main()
		{
		
			int len = getInvCount(arr.Length);
			Console.WriteLine("Number of inversions are {0}",len);
		

		}
	}

}
