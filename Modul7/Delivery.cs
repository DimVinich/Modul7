using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{

	abstract class Delivery
	{
		public string Address;

		public virtual void PrintInfo()
        {
			Console.WriteLine("Адрес доставки:  " + Address);
        }
	}

	class HomeDelivery : Delivery 
	{
		public string sayCustomer;

        public HomeDelivery(string address, string sayCustomer)
        {
			Address = address;
			this.sayCustomer = sayCustomer;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
			Console.WriteLine("Передать на словах:  " + sayCustomer);
		}
	}

	class PickPointDelivery : Delivery { /* ... */ }
	class ShopDelivery : Delivery { /* ... */ }
}
