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
			/*//method1
			//int[] array  = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };//recentlyPractise
			//method2
			//int[] array3 = { 1, 2, 3, };
			//method3
			int length = 10;
			int[] array = new int[length];
			array[0] = 5;
			Console.Write(array[0] + "，");

			for (int i = 1; i < length; i++)
			{
				//Thread.Sleep(1);

				array[i] = array[i - 1] + Console.Write(array[1] + " ,");
				Console.Write(array[i] + "，");

				//int random2 = new Random().Next(10);
				//Console.WriteLine(new Random().Next(1,5));
			}*/

			int length = 10;//定义长度
			int[] array = new int [length];//生成数组
			array[0] = 5;//第一位数组
			Console.Write(array[0] + ",");

			for (int i = 1; i < length; i++)
			{
				int random = new Random().Next(10);//生成随机数
				array[i] = array[i - 1] + random;//为什么必须要在前一个数上加，而不能自增呢？（自增会出现随机数相同）
				Console.Write(array[i] + ",");
			}
			Console.Read();

		}
	}
}