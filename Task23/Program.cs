using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask23
{
	internal class Program
	{
		static int calcCube(int n)
		{
			return Convert.ToInt32(Math.Pow(n, 3));
		}
		static void Main(string[] args)
		{
			int N;

			Console.Write("Введите число: ");
			N = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i < N + 1; i++)
			{
				Console.Write(calcCube(i) + " ");
			}

			Console.ReadLine();

		}
	}
}
