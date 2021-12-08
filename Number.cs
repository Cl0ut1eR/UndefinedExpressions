using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndefinedExpressions
{
    static class NumberTypes { public enum types { Value,Infinity,Zero}; }
    internal abstract class Number
    {
        public abstract NumberTypes.types type { get; }
        public Number value;
        public abstract override string ToString();

        public virtual double dblValue { get; }
        public static Number operator *(Number number, double value)
        {
            switch (number.type)
            {
                case NumberTypes.types.Value:
                    return new Value(number.dblValue*value);
                case NumberTypes.types.Infinity:
                    return new Infinity(number.value * value);
                case NumberTypes.types.Zero:
                    return new Zero(number.value * value);
            }
            throw new ArgumentException();
        }
        public static Number operator *(double value, Number number)
        {
            return number * value;
        }
        public static Number operator *(Number number, Number number1)
        {
            switch (number.type)
            {
                case NumberTypes.types.Value:
                    if(number1.type == NumberTypes.types.Value)
                    {
                        return new Value(number.dblValue * number1.dblValue);
                    }
                    else
                    {
                        return number.dblValue * number1;
                    }
                case NumberTypes.types.Infinity:
                    switch (number1.type)
                    {
                        case NumberTypes.types.Value:
                            return number.value * number1.dblValue;
                        case NumberTypes.types.Infinity:
                            return new Infinity(number.value * number1.value);
                        case NumberTypes.types.Zero:
                            return number.value * number1.value;
                    }
                    throw new ArgumentException();
                case NumberTypes.types.Zero:
                    switch (number1.type)
                    {
                        case NumberTypes.types.Value:
                            return new Zero(number.value * number1.dblValue);
                        case NumberTypes.types.Infinity:
                            return number.value = number1.value;
                        case NumberTypes.types.Zero:
                            /*didint follow the chart**** return new Zero(1 / (number.value * number1.value));*/
                            return new Zero(number.value * number1.value);
                    }
                    throw new ArgumentException();
            }
            throw new ArgumentException();
        } 
        public static Number operator /(Number number, double value)
        {
            switch (number.type)
            {
                case NumberTypes.types.Value:
                    return new Value(number.dblValue/value);
                case NumberTypes.types.Infinity:
                    return new Infinity(number.value / value);
                case NumberTypes.types.Zero:
                    return new Zero(number.value / value);
            }
            throw new ArgumentException();
        }        
        public static Number operator /(double value, Number number)
        {
            switch (number.type)
            {
                case NumberTypes.types.Value:
                    return new Value(value / number.dblValue);
                case NumberTypes.types.Infinity:
                    break;
                case NumberTypes.types.Zero:
                    break;
            }
            throw new ArgumentException();
        }
        public static Number operator /(Number number, Number number1)
        {
            switch (number.type)
            {
                case NumberTypes.types.Value:
                    if(number1.type == NumberTypes.types.Value)
                    {
                        return new Value(number.dblValue / number1.dblValue);
                    }
                    else
                    {
                        return number.dblValue / number1;
                    }
                case NumberTypes.types.Infinity:
                    switch (number1.type)
                    {
                        case NumberTypes.types.Value:
                            return number / number1.dblValue;
                        case NumberTypes.types.Infinity:
                            break;
                        case NumberTypes.types.Zero:
                            break;
                    }
                    throw new ArgumentException();
                case NumberTypes.types.Zero:
                    switch (number1.type)
                    {
                        case NumberTypes.types.Value:
                            return number / number1.dblValue;
                        case NumberTypes.types.Infinity:
                            break;
                        case NumberTypes.types.Zero:
                            break;
                    }
                    throw new ArgumentException();
            }
            throw new ArgumentException();
        }
    }
}
