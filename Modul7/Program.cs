using System;

namespace Modul7
{
	class Program
	{
		static void Main(string[] args)
		{

			//	Создаём доставку до дома
			HomeDelivery homeDelivery;
			homeDelivery = new HomeDelivery("Вот прям на третий этаж", "Специально для Глаши");

			//	Создаём покупателя
			Customer customer;
			customer = new Customer("Вася", "910-351-48-14");

			//	Создаём экспедитора
			Employee forwarder;
			forwarder = new Employee("Курьер № 13", "922-011-01-01", true);

			//	Создаём Банан
			Banana banana;
			banana = new Banana(15);

			//	Добавляем банан в заказ
			Product<Herb> product;
			double kol = 15;
			double price = 100.2;
			product = new Product<Herb>(banana, kol, price);

			//	Созадём заказ
			int numberOrder = 135;
			DateTime dateOrder = Convert.ToDateTime("2022.01.01");

			Order<HomeDelivery, Customer, Employee> order;
			order = new Order<HomeDelivery, Customer, Employee>(numberOrder, dateOrder, homeDelivery, customer, forwarder, product);

			//	Печатаем заказ
			order.PrintOrder();

            Console.ReadKey();
		}
	}

}