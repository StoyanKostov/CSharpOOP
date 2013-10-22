using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericList<T>
    {
        // Fieleds
        private T[] elementHolder;
        private int capacity;
        private int index = 0;

        // Methods
        public void Add(T element)
        {
            this.elementHolder[index] = element;
            index++;
        }

        public void Remove(int index)
        {
            for (int i = index; i < elementHolder.Length - 2; i++)
            {
                this.elementHolder[i] = this.elementHolder[i + 1];
            }

            this.elementHolder[elementHolder.Length - 1] = default(T);
        }

        public void Insert(int index, T element)
        {
            T[] temp = new T[this.elementHolder.Length + 1];

            for (int i = 0, j = 0; j < temp.Length - 1; i++, j++)
            {
                if (i == index)
                {
                    temp[j] = element;
                    j++;
                }
                else
                {
                    temp[j] = this.elementHolder[i];
                } 
            }


        }

        // Indexers
        public T this[int index]
        {
            get { return this.elementHolder[index]; }
        }

        // Constructor
        public GenericList(int capacity = 8)
        {
            this.elementHolder = new T[capacity];
        }

    }
}
