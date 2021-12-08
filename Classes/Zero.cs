using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndefinedExpressions
{
    internal class Zero : Number
    {
        public Zero(Number number)
        {
            value = number;
        }
        public Zero(double aValue)
        {
            value = new Value(aValue);
        }
        public override NumberTypes.types type => NumberTypes.types.Zero;

        public override string ToString()
        {
            if(value != null)
            {
                return "ZERO[" + value.ToString() + "]";
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
