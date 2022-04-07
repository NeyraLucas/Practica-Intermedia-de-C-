using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class ExceptionExample : NullReferenceException
    {
       public ExceptionExample(bool valor)
        {
            if (!valor)
            {
                throw new ArgumentNullException(nameof(valor));
            }
        }
       
        public string ValueNull(bool valor)
        {
            if (!valor)
            {
                return "La variable es nulla";
            }

            return "";
        }
    }
}
