using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class ComplexNumber
    {
        public double Real;
        public double Imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) {
            return new ComplexNumber(a['r'] + b['r'], a['i'] + b['i']);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a['r'] - b['r'], a['i'] - b['i']);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a['r'] * b['r'] - a['i'] * b['i'], a['r'] * b['i'] + a['i'] * b['r']);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double denominator = b['r'] * b['r'] + b['i'] * b['i'];
            ComplexNumber meter = a*( new ComplexNumber(b['r'], b['i']*-1));
            meter['r'] /= denominator;
            meter['i'] /= denominator;
            return meter;
        }

        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return a['r'] == b['r'] && a['i'] == b['i'];
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }

        public static bool operator >(ComplexNumber a, ComplexNumber b)
        {
            return Math.Sqrt(a['r'] * a['r'] + a['i'] * a['i']) > Math.Sqrt(b['r'] * b['r'] + b['i'] * b['i']);
        }

        public static bool operator <(ComplexNumber a, ComplexNumber b)
        {
            return Math.Sqrt(a['r'] * a['r'] + a['i'] * a['i']) < Math.Sqrt(b['r'] * b['r'] + b['i'] * b['i']);
        }

        public static implicit operator ComplexNumber(double number) {
            return new ComplexNumber(number, 0);
        }

        public static explicit operator double(ComplexNumber number) {
            return number['r'];
        }  

        public double this[int index]
        {
            get 
            {
                if (index == 0)
                    return Real;
                else if (index == 1)
                    return Imaginary;
                else
                    throw new ArgumentOutOfRangeException("Index 0 and 1 are only available");
            }
            set {
                if (index == 0)
                    Real = value;
                else if (index == 1)
                    Imaginary = value;
                else
                    throw new ArgumentOutOfRangeException("Index 0 and 1 are only available");
            }
            
        }

        public double this[char index]
        {
            get
            {
                if (index == 'r')
                    return Real;
                else if (index == 'i')
                    return Imaginary;
                else
                    throw new ArgumentOutOfRangeException("Index 'r' and 'i' are only available");
            }
            set
            {
                if (index == 'r')
                    Real = value;
                else if (index == 'i')
                    Imaginary = value;
                else
                    throw new ArgumentOutOfRangeException("Index 'r' and 'i' are only available");
            }

        }

        public override string ToString()
        {
            if (this['i'] == 0)
                return ((double)this).ToString();
            else if (this['r'] == 0)
                return $"{this['i']}i";
            else
                return $"{this['r']} + {this['i']}i";
        }

        public override bool Equals(object obj)
        {
            return obj is ComplexNumber number &&
                   Real == number.Real &&
                   Imaginary == number.Imaginary;
        }


    }
}
