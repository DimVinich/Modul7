using System;

namespace Modul7
{
	class Program
	{
		static void Main(string[] args)
		{
			//Order<HomeDelivery> order1 = new Order<int>();
			//Order<string> order2 = new Order<string>();

			//order1.Number = 1234;
			//order2.Number = "NN-1234";

			//int number1 = order1.Number;
			//string number2 = order2.Number;

			Console.ReadLine();
		}
	}

	class Order<TDelivery> where TDelivery : Delivery
	{
		//public T Number;
		//public string Description;

		public TDelivery Delivery;
		public void DisplayAddress()
		{
			Console.WriteLine(Delivery.Address);
		}


	}

	abstract class Delivery
	{
		public string Address;
	}
	class HomeDelivery : Delivery { /* ... */ }
	class PickPointDelivery : Delivery { /* ... */ }
	class ShopDelivery : Delivery { /* ... */ }

}