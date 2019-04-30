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
			//14课变量作业随机产生1-1000数值，10次内猜到它！
			
			int random = new Random().Next(1000);
			Console.WriteLine("系统会生成一个1-1000的数值让我们在10次内猜到它吧！");
			for (int i = 0; i < 10; i++)
			{
				int import = Convert.ToInt32(Console.ReadLine());

				if (import > random)
				{
					Console.WriteLine($"第{i + 1}次回答,大了");

				}
				else if (import < random)
				{

					Console.WriteLine($"第{i + 1}次回答，小了");

				}
				else
				{
					Console.WriteLine($"第{i + 1}次回答，答对了");

				}


			}
			Console.WriteLine($"真笨是：{random}啦");
			Console.Read();

		}
	}
}