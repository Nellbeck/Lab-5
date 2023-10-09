using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Triangel
    {
        float[] _SideLenght = new float[3]; // property that's an array
        public Triangel(float input1, float input2) // constructor with 2 parameters.
        {
            _SideLenght[0] = input1;
            _SideLenght[1] = input2;
        }

        public Triangel(float input1, float input2, float input3) // constructor with 3 parameters that will overload the first constructor if the object have 3 parameters.
        {
            _SideLenght[0] = input1;
            _SideLenght[1] = input2;
            _SideLenght[2] = input3;
        }

        
        public float GetTriangelCircumference()
        {
            float circumference = _SideLenght[0] + _SideLenght[1] + _SideLenght[2];
            return circumference;
        } // method to calculate the circumference of the triangel.
        public float GetTriangelArea()
        {
            float area = _SideLenght[0] * _SideLenght[1] / 2;
            return area;
        } // method to calculate the area of the triangel.
    }
}
