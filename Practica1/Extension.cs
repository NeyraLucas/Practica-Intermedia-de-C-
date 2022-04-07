using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public static class Extension
    {
        public static dynamic ShowArr(this Map<TestAbstract> arr)
        {
            return arr[0];
        }
    }
}
