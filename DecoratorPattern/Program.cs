using DecoratorPattern.DecoratorPattern;
using System;
using DecoratorPattern.DecoratorPattern.Decorators;

namespace DecoratorView
{
    class Program
    {
        static void Main(string[] args)
        {
            Behior espresso = new Espresso();
            espresso = new Mocha(espresso);
            espresso = new Milk(espresso);
            espresso = new Soy(espresso);
            Console.WriteLine(espresso.GetDescription());
            Console.WriteLine(espresso.Cost());
        }
    }
}