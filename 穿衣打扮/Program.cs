using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 穿衣打扮
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("xcl");

            p.Show();

            Console.WriteLine();
            TShirts t = new TShirts();
            BigTrouser bt = new BigTrouser();
            Shoes s= new Shoes();

            t.Decorate();
            bt.Decorate();
            s.Decorate();

            Console.Read();

        }
    }

    //要装饰的人
    class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("装扮者{0}",name);
        }
    }

    //服饰类
    abstract class Finery
    {
        public abstract void Decorate();
    }

    
    class  TShirts:Finery
    {
        public override void Decorate()
        {
            Console.WriteLine("T衬衫");
        }
    }

    class BigTrouser:Finery
    {
        public override void Decorate()
        {
            Console.WriteLine("大垮裤");
        }
    }

    class Shoes : Finery
    {
        public override void Decorate()
        {
            Console.WriteLine("鞋子");
        }
    }
}
