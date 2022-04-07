using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Map<T>
        where T : AbstractExample
    {
           private T[] array = new T[50];

            public T this [int index]
            {
                get { return array[index]; }

                set { array[index] = value; }
            }

        public dynamic SearchByKey(string txt)
        {
             try
             {
                 foreach(var arr in array)
                 {
                     if (arr.Key.Equals(txt))
                     {
                         return arr;
                    }
                    else
                    {
                        return "Error";
                    }             
                 }
                throw new Exception("Nothing");
             }catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }

            return "Nothing";
            


        }

    }

}
