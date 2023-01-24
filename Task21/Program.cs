using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask21
{
	internal class Program
	{
		static int[] enterPoints(int []Array)
		{
			for (int i = 0; i < 3; i++)
			{
				Array[i] = Convert.ToInt32(Console.ReadLine());
			}

			return Array;
		}

		static double calcDistance(int []A, int []B)
		{
			return Math.Round(Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2) + Math.Pow(B[2] - A[2], 2)), 2);
		}

		static void Main(string[] args)
		{
			int[] A = new int[3], B = new int[3];

			Console.WriteLine("Введите x,y,z первой точки");
			enterPoints(A);

			Console.WriteLine("\n\nВведите x,y,z второй точки");
			enterPoints(B);

			Console.WriteLine("\nРасстояние между точками в 3D пространстве = " + calcDistance(A, B));
			Console.ReadLine();
		}
	}
}

