using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{
	class Order<TDelivery, TCustomer, TEmployee> 
		where TDelivery : Delivery
		where TCustomer : People
		where TEmployee : Employee
	{
		protected TDelivery Delivery;
		protected TCustomer Customer;
		protected TEmployee Employee;
		public int numOrder;
		public DateTime dateOrder;
		protected Product<Herb> Product;

		public Order(int numorder, DateTime dateorder, TDelivery delivery, TCustomer customer, TEmployee forwarder, Product<Herb> product)
        {
			numOrder = numorder;
			dateOrder = dateorder;
			Delivery = delivery;
			Customer = customer;
			Employee = forwarder;
			Product = product;
        }

		public void PrintOrder()
		{
			Console.WriteLine(" Заказ № {0} от {1} ", numOrder, dateOrder);
			
			Console.WriteLine("\n Данные клиента ");
			Customer.PrintInfo();

			Console.WriteLine("\n Данные экспедитора ");
			Employee.PrintInfo();

			Console.WriteLine("\n Данные доставки ");
			Delivery.PrintInfo();

			Console.WriteLine("\n Данные о продукте ");
			Product.PrintInfo();
		}

		// ==================  Реализация индексатора для продуктов.
		protected Product<Banana>[] ArrProduct;

        public Product<Banana> this[int index]
        {
            get
            {
                if (index >= 0 && index < ArrProduct.Length)
                {
                    return ArrProduct[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < ArrProduct.Length)
                {
                    ArrProduct[index] = value;
                }
            }
        }

        public void SetArrProduct(Product<Banana>[] arrProduct)
        {
            ArrProduct = arrProduct;
        }

		public void PrintArrProduct()
        {
			for (int i = 0; i < ArrProduct.Length; i++)
            {
				Console.WriteLine("\n\n Дополнительная позиция № {0}", i + 1);
				ArrProduct[i].PrintInfo();
            }
        }

    }
}
