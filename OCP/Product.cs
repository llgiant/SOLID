using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    #region Product
    //1 
    public enum Color
    {
        Red, Green, Blue
    }
    public enum Size
    {
        Small, Large, Big, Huge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string Name, Color Color, Size Size)
        {
            this.Color = Color;
            this.Size = Size;
            this.Name = Name;
        }
    }
    #endregion

    //2 необходимо реализовать фильтр-сервис поиска по цвету, путем создния класса ProductFilter и метода FilterByColor
    #region Filtering
    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.Color == color)
                    yield return p;

            }
        }

        //3 необходимо реализовать фильтр-сервис поиска по размеру, путем создния  метода Filter
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
            {
                if (p.Size == size)
                    yield return p;
            }
        }
        // TEST1
        //4 необходимо реализовать фильтр-сервис поиска по цвету и размеру, путем создния метода FilterBySizeAndColor
        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
            {
                if (p.Size == size && p.Color == color)
                    yield return p;
            }
        }

        //5 исходя из вышеизложенного нам необходимо усилить принцип который гласит " Тип открыт для рсширения но закрыт для
        //модификции"
        //Другими словами мы хотим получить фильтрацию которую можно расширить(возможно и в другой сборке) 
        //без модификаации(и рекомпеляции того, что уже работает и могло быть предоставлено заказчику)

        //как же этого достичь?
        //в первую очередь необходимо концептуально разделить (SPR) процесс фильтрации на 2 части
        //6  (часть 1) - фильтер - конструкция которая берет коллекцию продуктов и возвращает только некоторые
        public interface IFilter<T>
        {
            IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
        }

        //7  (часть 2) - спецификация - предикат который применим к элементу данных
        public interface ISpecification<T>
        {
            bool IsSatisfied(T item); //Типом Т может быть что угодно даже Product, что позволяет 
            //переиспользовать данный подход
        }

        //8
        public class BetterFilter : IFilter<Product>
        {
            public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
            {
                foreach (var i in items)
                {

                    if (!spec.IsSatisfied(i))
                    {
                        yield return i;
                    }
                }
            }
        }

        //9 Color Filter - TEST2
        public class ColorSpecification : ISpecification<Product>
        {
            private Color color;

            public ColorSpecification(Color color)
            {
                this.color = color;
            }
            public bool IsSatisfied(Product p)
            {
                return p.Color == color;
            }
        }
    }
    #endregion


}