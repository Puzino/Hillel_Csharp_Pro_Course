using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework_3
{
	public class ClassArray : IOutput, IMath, ISort
	{

		List<int> ints;

		public ClassArray(List<int> ints)
		{
			this.ints = ints;
		}

        // Interface IMath
        
        public float Avg()
        {
            return (float)ints.Sum() / ints.Count;
        }

        public int Max()
        {
			return ints.Max();
        }

        public int Min()
        {
			return ints.Min();
        }

        public bool Search(int valueToSearch)
        {
			return ints.Contains(valueToSearch);
        }

        // Interface IOutput

        public void Show()
		{
			foreach (int item in ints)
			{
				Console.WriteLine(item);
			}
		}

		public void ShowInfo(string info)
		{
			Console.WriteLine(info);
			Show();
		}

        // Interface ISort

        public void SortAsc()
        {
            int n = ints.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        public void SortDesc()
        {
            int n = ints.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (ints[j] < ints[j + 1])
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}

