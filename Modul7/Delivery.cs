using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{
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
