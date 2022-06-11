using System;

namespace Modul7
{
    class Program
    {
        static void Main(string[] args)
        {
			SmartHelper helper = new SmartHelper("Олег");
			helper.Greetings("Грег");

            Console.ReadLine();
        }
    }

	class IndexingClass 
	{
	  private int[] array;

	  public IndexingClass(int[] array) 
	  {
		this.array = array;
	  }
		public int this[int index]
        {
            get
            {
				if (index > 0 && index < array.Length)
                {
					return array[index];
                }
                else
                {
					return null;
                }
            }

            set
            {
				if (index > 0 && index < array.Length)
                {
					array = value;
                }
            }
        }
		

	}

	class SmartHelper 
	{
	  private string name;

	  public SmartHelper(string name) 
	  {
		this.name = name;
	  }

	  public void Greetings(string name) 
	  {
		Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
	  }
	}

	class Herb { }
	class Fruit : Herb { }
	class Vegetable : Herb { }
	class Berries : Herb { }
	class Apple : Fruit { }
	class Banana : Berries { }
	class Pear : Fruit { }
	class Potato : Vegetable { }
	class Carrot : Vegetable { }

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
