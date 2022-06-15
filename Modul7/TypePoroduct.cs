using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{
    class Product
    {

    }

	abstract class Herb 
	{ 
		public int StorageLife { get; }
		protected bool fNeedFrige;

		public Herb(int strfgeLife)
        {
			StorageLife = strfgeLife;
			fNeedFrige = false;
        }

		public bool GetNeedFrige()
        {
			return fNeedFrige;
        }

        public void PrintEndDateStorage()
        {
            Console.WriteLine("Срок годности до " + DateTime.Now.AddDays(StorageLife).ToString());
        }

        public void PrintEndDateStorage(DateTime aDateProd)
        {
            Console.WriteLine("Срок годности до " + aDateProd.AddDays(StorageLife).ToString());
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
