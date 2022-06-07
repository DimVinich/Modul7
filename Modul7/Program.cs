﻿using System;

namespace Modul7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }

	class ProjectManager : Employee
    {
		public string ProjectName;

	}

	class Developer : Employee
    {
		public string ProgrammingLanguage;

	}

	class Employee
	{
		public string Name;
		public int Age;
		public int Salary;
	}

	class HybridCar : Car
	{
		public FuelType FuelType;

		public void ChangeFuelType(FuelType type)
		{
			FuelType = type;
		}
	}
	class Car
	{
		public double Fuel;
		public int Mileage;

		public Car()
		{
			Fuel = 50;
			Mileage = 0;
		}

		public void Move()
		{
			// Move a kilometer
			Mileage++;
			Fuel -= 0.5;
		}

		public void FillTheCar()
		{
			Fuel = 50;
		}
	}
	enum FuelType
    {
        Gas = 0,
        Electricity
    }
}
