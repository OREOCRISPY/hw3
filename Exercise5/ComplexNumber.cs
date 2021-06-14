using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class ComplexNumber
    {
        private int real;
        private int imaginary;
        public ComplexNumber(int real,int imaginary) {
            this.real = real;
            this.imaginary = imaginary;
        }
        public int Real {
            set { this.real = value; }
            get { return this.real; }
        }

        public int Imaginary
        {
            set { this.imaginary = value; }
            get { return this.imaginary; }
        }

        public String ToString() {
            String k = "(" + real + "," + imaginary + ")";
            return k;
        }

        public double GetMagnitude() {
            return Math.Sqrt(real * real + imaginary * imaginary);
        }
        public void Add(ComplexNumber i) {
            this.real += i.real;
            this.imaginary += i.imaginary;
        }
    }
}
