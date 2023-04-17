using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestColor
{
    internal struct Hexadecimal
    {
        private string _currentValue;
        private readonly string decimalNumbers = "0123456789";

        private static Lazy<Hexadecimal> _maxValue = new Lazy<Hexadecimal>(new Hexadecimal("F"));
        private static Lazy<Hexadecimal> _minValue = new Lazy<Hexadecimal>(new Hexadecimal("0"));

        public static Hexadecimal MAX_VALUE => _maxValue.Value;
        public static Hexadecimal MIN_VALUE => _minValue.Value;

        private int IntEquivalent
        {
            get
            {
                //Si de 0 à 9
                if (decimalNumbers.Contains(_currentValue))
                    return int.Parse(_currentValue);

                //Si de A à F
                switch (_currentValue)
                {
                    case "A":
                        return 10;
                    case "B":
                        return 11;
                    case "C":
                        return 12;
                    case "D":
                        return 13;
                    case "E":
                        return 14;
                    case "F":
                        return 15;
                }

                //Si non hexadécimal
                throw new ArgumentOutOfRangeException(nameof(_currentValue), _currentValue);
            }
        }

        public Hexadecimal(string value)
        {
            _currentValue = value;
        }

        public Hexadecimal(int value)
        {
            //Si de 0 à 9
            if (value < 10)
                _currentValue = value.ToString();

            //Si de 10 à 15
            switch (value)
            {
                case 10:
                    _currentValue = "A";
                    break;
                case 11:
                    _currentValue = "B";
                    break;
                case 12:
                    _currentValue = "C";
                    break;
                case 13:
                    _currentValue = "D";
                    break;
                case 14:
                    _currentValue = "E";
                    break;
                case 15:
                    _currentValue = "F";
                    break;
            }
        }

        public static bool operator >(Hexadecimal left, Hexadecimal right)
        {
            return left.IntEquivalent > right.IntEquivalent;
        }
        public static bool operator <(Hexadecimal left, Hexadecimal right)
        {
            return left.IntEquivalent < right.IntEquivalent;
        }

        public static bool operator >=(Hexadecimal left, Hexadecimal right)
        {
            return left.IntEquivalent >= right.IntEquivalent;
        }
        public static bool operator <=(Hexadecimal left, Hexadecimal right)
        {
            return left.IntEquivalent <= right.IntEquivalent;
        }

        public static Hexadecimal operator +(Hexadecimal left, Hexadecimal right)
        {
            var result = left.IntEquivalent + right.IntEquivalent;
            return new Hexadecimal(result.ToString());
        }
        public static Hexadecimal operator -(Hexadecimal left, Hexadecimal right)
        {
            var result = left.IntEquivalent - right.IntEquivalent;
            return new Hexadecimal(result);
        }
        public static bool operator ==(Hexadecimal left, Hexadecimal right)
        {
            return left.IntEquivalent == right.IntEquivalent;
        }
        public static bool operator !=(Hexadecimal left, Hexadecimal right)
        {
            return left.IntEquivalent != right.IntEquivalent;
        }

        public override string ToString()
        {
            return _currentValue;
        }
    }
}
