using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 穿衣打扮_装饰者
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("xcl");
            Console.WriteLine("第一种装扮");
            Console.WriteLine();

            TShirts t= new TShirts();
            BigTrouser bt= new BigTrouser();
            Shoes s = new Shoes();

            t.Decorate(p);
            bt.Decorate(t);
            s.Decorate(bt);

            s.Show();

            Console.Read();
        }
    }

    //要装饰的人
    class Person
    {
        private string name;

        public Person()
        {
        }

        public Person(string name)
        {
            this.name = name;
        }

        public virtual  void Show()
        {
            Console.WriteLine("装扮者{0}", name);
        }
    }

    //服饰类
    abstract class Finery:Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }


    class TShirts : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("T衬衫");
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("大垮裤");
        }

    }

    class Shoes : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("鞋子");
        }

    }
}
