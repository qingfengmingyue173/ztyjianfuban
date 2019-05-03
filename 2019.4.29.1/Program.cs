using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._4._29._1
{
	class Program
	{
		static void Main(string[] args)
		{
			//实现数组
			Console.WriteLine("数组：1, 8, 13, 14, 25, 26, 37, 68, 99, 100, 110, 123, 136, 314, 415");
			int[] array = new int[] { 1, 8, 13, 14, 25, 26, 37, 68, 99, 100, 110, 123, 136, 314, 415 };

			//实现输入
			Console.WriteLine("请输入要查找的数；");
			int input = Convert.ToInt32(Console.ReadLine());

			//max标，min标，初始标
			int max = array.Length - 1;
			int min = 0;
			int initial = 0;
			int shift = 0;
			int i = 0;
			int j = 1;

			while(i < 8)
			{
				i++;
				j++;
				while (input == array[initial])
					{
						Console.WriteLine($"第{j}次查找，查找数值为{array[initial]}数据匹配查找完成");
						i = 8;
						break;
					}
				while(input > array[initial])
					{
						Console.WriteLine($"第{j}次查找，查找数值为{array[initial]}下标为[{initial}]");
						min = initial;
						shift = (max - min) / 2;
						initial += shift;
						Console.WriteLine($"下一次查找将向右移动{shift}位\n");
					}
				while(input < array[initial])
					{
						Console.WriteLine($"第{j}次查找，查找数值为{array[initial]}下标为[{initial}]");
						max = initial;
						shift = (max - min) / 2;
						initial -= shift;
						Console.WriteLine($"下一次查找将向左移动{shift}位\n");
					}	
			}
			
			while(i < 9 && i > 8)
				{
					i++;
					Console.WriteLine($"输出错误，此数组没有{input}数值");
				}

			Console.Read();
		}
	}
}