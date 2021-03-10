using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgRGZ2
{
    class HeapSort
    {
		public List<int> HSort(int size, List<int> array)
		{
			int t;
			while (size > 0)
			{
				//максимальный эл-т перемещается на 0-е место(сортировка дерева)
				for (int i = (size - 1) / 2; i >= 0; i--)
				{
					if (2 * i + 1 < size)
					{
						if (array[i] < array[2 * i + 1])
						{
							t = array[i];
							array[i] = array[2 * i + 1];
							array[2 * i + 1] = t;
						}
					}

					if (2 * i + 2 < size)
					{
						if (array[i] < array[2 * i + 2])
						{
							t = array[i];
							array[i] = array[2 * i + 2];
							array[2 * i + 2] = t;
						}
					}
				}

				//Перемещение 0-го эл-та в "начало конца", уменьшение дерева и повтор сортировки
				t = array[0];
				array[0] = array[size - 1];
				array[size - 1] = t;

				size--;
			}
			return array;
		}


	}
}
