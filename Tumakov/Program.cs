using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Class2;

namespace Tumakov
{
    enum Typee
    {
        Saved,
        Personal
    }
    class Bank
    {
        private Guid rootcheck;
        private double balanse;
        private string typecheck = Convert.ToString(Typee.Personal);
        static Guid root = Guid.NewGuid();

        public Guid Root
        {
            get { return rootcheck; }
            set { rootcheck = value; }
        }

        public double Balanse
        {
            get { return balanse; }
            set { balanse = value; }
        }

        public string Type
        {
            get { return typecheck; }
            set { typecheck = value; }
        }

        public void TakeoffMoney(int a)
        {
            if (a <= balanse)
            {
                balanse = balanse - a;
            }
            else
            {
                Console.WriteLine("Hедостаточно средств");
            }
        }
        public void CHeckMoney()
        {
            Console.WriteLine($"{balanse}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bank bank = new Bank();
            //bank.Balanse = 10000;
            //Console.WriteLine(bank.Balanse);
            //bank.TakeoffMoney(99);
            //Console.WriteLine(bank.Balanse);
            //bank.TakeoffMoney(100000);
            //bank.CHeckMoney();

            
            
            
            House house = new House();
            house.Rt(100);
            Console.WriteLine(house.Root);
            
            
            Console.Read();


        }
    }
}
