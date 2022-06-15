using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{

    abstract class People
    {
        public string Name { get; }
        public string FoneNumber { get; }

        public People(string aName, string afoneNumber)
        {
            Name = aName;
            FoneNumber = afoneNumber;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Имя {0}   Номер телефона {1}", Name, FoneNumber);
        }
    }

    class Employee : People
    {
        public bool isOnShift;

        public Employee(string aName, string afoneNumber, bool aisOnShift) : base(aName, afoneNumber)
        {
            isOnShift = aisOnShift;
        }

        public override void PrintInfo()
        {
            string sh = isOnShift ? " на смене " : " выходной ";
            Console.WriteLine(" Сотрудник {0}   Номер телефона {1}  сегодня " + sh  , Name, FoneNumber);
        }

    } 

    class Customer : People
    {
        public Customer(string aName, string afoneNumber) : base(aName, afoneNumber)
        {

        }
    }

}
