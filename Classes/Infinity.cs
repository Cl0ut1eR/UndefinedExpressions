using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndefinedExpressions
{
    public class Infinity : Number
    {
        public Infinity(Number number)
        {
            this.value = number;
        }        
        public Infinity(double aValue)
        {
            this.value = new Value(aValue);
        }

        public override NumberTypes.types type => NumberTypes.types.Infinity;

        public override string ToString()
        {
            if (value != null)
            {
                return "INFINITY[" + value.ToString() + "]";
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
