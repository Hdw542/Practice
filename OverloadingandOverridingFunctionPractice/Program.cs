using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingandOverridingFunctionPractice
{
    class secondClass
    {
        private float length;
        private float bredth;
        private float height;

        public void setLength(float len)
        {
            length = len;
        }

        public void setBredth(float bre)
        {
            bredth = bre;
        }

        public void setHeight(float hei)
        {
            height = hei;
        }

        public float volume()
        {
            return length * bredth * height;
        }

        public static secondClass operator +(secondClass c1, secondClass c2) // secondClass is the name of the class
        {
            secondClass calc = new secondClass();  // calc is the object and for overloading i will have to return the object
            calc.length = c1.length + c2.length;
            calc.bredth = c1.length + c2.length;
            calc.height = c1.height + c2.height;
            return calc;
        }
    };

    class Program 
    {
        /* overriding of functions occurs when one class inherits from another class & it is needed when
            derived class function has to do some added or different job than base class function. 
            Overloading can even occur without inheritance as they are in the same scope. Overloading is 
            used to have same name function behave differently depending upon he parameters passed
            Overloaded operators are functions with special names the keyword "operator" followed by
            the symbol for the operator being defined e.g "+".
             */
        // program to calculate volume using overloading operator
        static void Main(string[] args)
        {
            secondClass get1 = new secondClass();
            secondClass get2 = new secondClass();
            secondClass get3 = new secondClass();
            float volume = 0; // storing initial volume 
            
            // setting length, bredth and height for 1st output 
            get1.setLength(10);
            get1.setBredth(2);
            get1.setHeight(2);
            // getting volume for 1
            volume = get1.volume();
            // printing volume for 1st 
            Console.Out.WriteLine("Expected output = 40");
            Console.Out.WriteLine("Result Volume 1 = " + volume);

            // setting length, bredth and height for 2nd output
            get2.setLength(20);
            get2.setBredth(4);
            get2.setHeight(2);
            // getting volume for 2nd
            volume = get2.volume();
            // printing volume for 2nd
            Console.Out.WriteLine("Expected output = 160");
            Console.Out.WriteLine("Result Volume 2 = " + volume);

            // setting length, bredth and height for 3rd output
            get3.setLength(30);
            get3.setBredth(2);
            get3.setHeight(2);
            // getting volume for 3rd
            volume = get3.volume();
            // printing volume for 2nd
            Console.Out.WriteLine("Expected output = 120");
            Console.Out.WriteLine("Result Volume 3 = " + volume);

            Console.ReadLine();
        }
    }
}
