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

			//初始数组位数
			int length = array.Length - 1;

			for (int i = 0; i < array.Length; i++)
			{
				int interval = (length + 1) / 2;


				if (input == array[length])
				{
					Console.WriteLine($"第{i}次查找，数组第{length + 1}位，数值为{array[length]}数据匹配，查找完成！");
					break;
				}
				else
				{
					Console.WriteLine($"第{i}次查找，数组第{length + 1}位，数值为{array[length]}");
					if (input < array[length])
					{
						length -= interval;
					}
					else
					{
						length += interval;
					}
				}
			}
			Console.Read();

		}
	}
}