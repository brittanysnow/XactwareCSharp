using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			// Cylinders project
			
			Console.WriteLine("Enter Cylinder Height:");
			string height_userInput = Console.ReadLine();
			Console.WriteLine("Enter Cylinder Base Radias:");
			string baseRadias_userInput = Console.ReadLine();
			double cylinderHeight = Convert.ToDouble(height_userInput);
			double cylinderBaseRadias = Convert.ToDouble(baseRadias_userInput);
			double pi = 3.1415926;
			// Calculates the volume of the cylinder
			double volume = pi * (cylinderBaseRadias * cylinderBaseRadias) * cylinderHeight;
			double surface_area = 2 * pi * cylinderBaseRadias*(cylinderBaseRadias + cylinderHeight);

			Console.WriteLine("The volume of the cylinder is " + volume + " cubic units");
			Console.WriteLine("The surface area of the cylinder is " + surface_area + " square units");

			Console.ReadKey();

		}
	}
}
