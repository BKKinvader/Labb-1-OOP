using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1_OOP
{
    internal class Circle
    {
        // Constructor = Parameter och metod
        float _pi = 3.141f;
        int _Radius;
        int _Height;
        //Parameter samma namn som class
        public Circle(int Radie,int Height) // Radie är data skickat från Main 
        {
            this._Radius = Radie; // Ge _Radius ett nytt värde drån Main
            this._Height = Height;
        }

        //metod på hur man räknar ut area
        public void getArea()
        {
            Console.WriteLine(_Radius * _Radius * _pi);

        }

        public void getcircumference()
        {
            Console.WriteLine(_Radius + _Radius * _pi);

        }

        public void getvolume()
        {
            Console.WriteLine(_Radius * _Radius * _pi * _Height);

        }
    }
}
