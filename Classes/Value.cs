using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndefinedExpressions
{
    public class Value : Number
    {
        private double _value;

        public Value(double aValue)
        {
            _value = aValue;
            value = this;
        }
        public override double dblValue => _value;
        public override NumberTypes.types type => NumberTypes.types.Value;

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
