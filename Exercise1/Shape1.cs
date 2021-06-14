using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    abstract class Shape1
    {

        protected float R, L, B;

        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();

    }

    class Rectangle : Shape1 {

        public Rectangle() {
            Console.WriteLine("please enter length:");
            L =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter breadth:");
            B = Convert.ToInt32(Console.ReadLine());

        }
        public override float Area()
        {
            return L * B;
        }

        public override float Circumference()
        {
            return (L + B) * 2;
        }
    }

    class Circle : Shape1 {
        public Circle() {
            Console.WriteLine("please enter radius:");
            R = Convert.ToInt32(Console.ReadLine());
        }
        public override float Area()
        {
            return (float)Math.PI * R * R;
        }
        public override float Circumference()
        {
            return (float)Math.PI * 2 * R;
        }
    }

}
