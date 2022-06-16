using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{
    static class Arifmetical
    {
        public static double Sum(double kol, double price)
        {
            return kol * price;
        }
    }

    class Product<THerb> where THerb : Herb
    {
        public THerb Herb;
        public double kol;
        public double price;
        public double sum;

        public Product(THerb herb, double kol, double price) 
        { 
            Herb = herb;
            this.kol = kol;
            this.price = price;

            sum = Arifmetical.Sum(kol, price);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Вы заказали :");
            Herb.PrintInfo();
            Console.WriteLine("в количестве {0}  по цене {1} на сумму {2}", kol, price, sum);
        }
    }

	abstract class Herb 
	{
        protected int StorageLife;
		protected bool fNeedFrige;
        protected string nameHerb;

        protected Herb(int strfgeLife)
        {
			StorageLife = strfgeLife;
			fNeedFrige = false;
        }

		public bool GetNeedFrige()
        {
			return fNeedFrige;
        }

        public void PrintNeedFrige()
        {
            if (fNeedFrige)  Console.WriteLine("*требуется сумка холодильник"); 
        }

        public void PrintEndDateStorage()
        {
            Console.WriteLine("Срок годности до " + DateTime.Now.AddDays(StorageLife).ToString());
            PrintNeedFrige();
        }

        public void PrintEndDateStorage(DateTime aDateProd)
        {
            Console.WriteLine("Срок годности до " + aDateProd.AddDays(StorageLife).ToString());
            PrintNeedFrige();
        }

        public void PrintInfo()
        {
            Console.WriteLine(nameHerb);
            PrintEndDateStorage();
        }

    }

    abstract class Fruit : Herb
    {
        protected Fruit(int strfgeLife) : base(strfgeLife)
        {
        }
    }

    abstract class Vegetable : Herb
    {
        protected Vegetable(int strfgeLife) : base(strfgeLife)
        {
        }
    }

    abstract class Berries : Herb
    {
        protected Berries(int strfgeLife) : base(strfgeLife)
        {
            fNeedFrige = true;
        }
    }

    class Apple : Fruit
    {
        public Apple(int strfgeLife) : base(strfgeLife)
        {
        }
    }

    class Banana : Berries
    {
        public Banana(int strfgeLife) : base(strfgeLife)
        {
            nameHerb = "Банан";
        }
    }

    class Pear : Fruit
    {
        public Pear(int strfgeLife) : base(strfgeLife)
        {
        }
    }

    class Potato : Vegetable
    {
        public Potato(int strfgeLife) : base(strfgeLife)
        {
        }
    }

    class Carrot : Vegetable
    {
        public Carrot(int strfgeLife) : base(strfgeLife)
        {
        }
    }


}
