using System;

namespace Modul7
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.ReadLine();
		}
	}

	class Order<TDelivery> where TDelivery : Delivery
	{
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