using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Estructura
{


    /// <summary>
    /// Iterator Design Pattern
    /// </summary>
    public class Demo
    {
        public static void Ejecutar()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create Iterator and provide aggregate

            Iterator i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            object item = i.First();

            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }            
        }
    }
}

