using System.Collections.Generic;

namespace Iterator.Estructura
{
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>

    public class ConcreteAggregate : Aggregate
    {
        List<object> items = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Get item count

        public int Count
        {
            get { return items.Count; }
        }

        // Indexer

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}

