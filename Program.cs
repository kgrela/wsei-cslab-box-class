using System;
using System.Collections.Generic;
using System.Linq;

namespace wseicslabboxclass
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var lista = new List<Pudelko>
            {
                new Pudelko(0.2002, null, 0.10),
                new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter),
                new Pudelko(868.2, 374.21, 85.75, UnitOfMeasure.centimeter),
                new Pudelko(null, 25, null, UnitOfMeasure.milimeter),
                new Pudelko(270, 252, null, UnitOfMeasure.centimeter),
            };

            foreach (var n in lista)
                Console.WriteLine(n.ToString());

            var sortedList = lista
              .OrderBy(n => n.Objetosc)
              .ThenBy(n => n.Pole)
              .ThenBy(n => n.A + n.B + n.C)
              .ToList();

            foreach (var pudelko in sortedList)
                Console.WriteLine(pudelko.ToString());

            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).ToString("mm"));
            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).ToString("cm"));
            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).ToString("m"));

            Console.WriteLine("2.5, 9.321, 0.1");
            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).Objetosc);
            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).Pole);

            var box1 = new Pudelko(2.5, 9.321, 0.1);
            var box2 = new Pudelko(2.5, 9.321, 0.1);
            var box3 = new Pudelko(2.5, 9.21, 0.1);
            Console.WriteLine(box1.Equals(box2));
            Console.WriteLine(box1.Equals(box3));

            Console.WriteLine(box1.GetHashCode());
            Console.WriteLine(box3.GetHashCode());

            Console.WriteLine(box1.CompareTo(box1));
            Console.WriteLine(box1.CompareTo(box3));

        }
    }
}
