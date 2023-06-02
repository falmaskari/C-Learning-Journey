using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Rectangle1(double length, double width);
    class Rectangle
    {
        public void GetArea(double length, double width)
        {
            Console.WriteLine($"Area {length * width}");
        }
        public void GetAddArea(double length, double width)
        {
            Console.WriteLine($"Area {length + width}");
        }
        public void GetSubtractArea(double length, double width)
        {
            Console.WriteLine($"Area {length - width}");
        }
        public void GetDivisionArea(double length, double width)
        {
            Console.WriteLine($"Area {length / width}");
        }
        public void GetPerimeter(double length, double width)
        {
            Console.WriteLine($"Perimeter {2 * (length * width)}");
        }

        public double number;

        public Rectangle(double number)
        {
            this.number = number;
        }

        public static Rectangle operator *(Rectangle number1, Rectangle number2)
        {
            double output = number1.number * number2.number;
            return new Rectangle(output);
        }

        public static Rectangle operator /(Rectangle number1, Rectangle number2)
        {
            double output = number1.number / number2.number;
            return new Rectangle(output);
        }
        public static Rectangle operator +(Rectangle number1, Rectangle number2)
        {
            double output = number1.number + number2.number;
            return new Rectangle(output);
        }
        public static Rectangle operator -(Rectangle number1, Rectangle number2)
        {
            double output = number1.number - number2.number;
            return new Rectangle(output);
        }
        public static Rectangle operator -(Rectangle number1, Rectangle number2)
        {
            double output = number1.number - number2.number;
            return new Rectangle(output);
        }
    }
}
