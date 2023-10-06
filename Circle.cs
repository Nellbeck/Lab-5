using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Circle
    {
        float _Pi = 3.141F;
        float _Radius { get; set; }
        float _Circumference { get; set; } // Some properties.

        public Circle(float input)
        {
            _Radius = input;
            _Circumference = input; // A konstruktor that gives the variables a value.
        }

        public float GetCircelArea()
        {
            float area = _Radius * _Radius * _Pi;
            return area; // A method that calculate the area of a circle.
        }
        public float GetCircelCircumference()
        {
            float circumference = _Circumference * _Pi;
            return circumference; // A method that calculate the circumference of a circle.
        }
    }

}
