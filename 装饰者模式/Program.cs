using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //要装饰的对象
            ConcreteComponent c= new ConcreteComponent();

            //装饰者
            ConcreteDecoratorA d1=new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();

            Console.Read();


        }
    }

    //要装饰的对象
    abstract class Component
    {
        public abstract void Operation();
    }

    class  ConcreteComponent:Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体的对象操作");
        }
    }

    //装饰者类
    abstract class Decorator : Component
    {
        protected Component Component;

        public void  SetComponent(Component component)
        {
            Component = component;
        }

        public override void Operation()
        {
            if (Component != null)
            {
                Component.Operation();
            }
        }
    }

    //具体的装饰者A
    class ConcreteDecoratorA:Decorator
    {
        private string _addedState;
        public override void Operation()
        {
            base.Operation(); //首先运行原，component的Operation()，再执行本类的功能，如addState，相当于对原Component进行装饰
            _addedState = "New State";
            Console.WriteLine("具体装饰对象A操作");

        }
    }


    class ConcreteDecoratorB:Decorator
    {
        public override void Operation()
        {
            base.Operation(); //最后一次调用的B，那么先设置去掉用A
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
           
        }

        private void AddedBehavior()
        {

        }
    }
}
