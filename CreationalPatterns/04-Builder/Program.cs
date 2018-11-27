using System;

namespace _04_Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            Burger burger = new Burger(new BurgerBuilder(10)
                .AddLettuce()
                .AddPepporini()
                .AddTomato());
            Console.WriteLine("Hello World!");
        }
    }
}
