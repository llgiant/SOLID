using System;
using System.Collections.Generic;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test 1

            #endregion

            #region test 2
            var apple = new Product("Яблоко", Color.Green, Size.Small);
            var tree = new Product("Дерево", Color.Green, Size.Large);
            var house = new Product("Дом", Color.Blue, Size.Huge);
            Product [] products =  { apple, tree, house };

            var pf = new ProductFilter();

            Console.WriteLine("Зеленые продукты:");

            foreach (var p in pf.FilterByColor(products,Color.Green))
            {
                Console.WriteLine($" - {p.Name} Зеленое");
            }
            #endregion
        
        
        
        }
    }




}
