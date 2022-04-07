using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class GenericExample<T>
        where T : AbstractExample
    {
           private T[] array = new T[50];

            public T this [int index]
            {
                get { return array[index]; }

                set { array[index] = value; }
            }

    }

}
