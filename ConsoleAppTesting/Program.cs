using System;
using System.Drawing;

namespace ConsoleAppTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            PrintTheDoc printTheDoc = new PrintTheDoc();
            printTheDoc.PrintReport(new HPPrinter());
            printTheDoc.PrintReport(new LGPrinter());
            GTCollection vs = new GTCollection();


            Box b1 = new Box { length = 2, breadth = 3 };
            Box b2 = new Box { length = 4, breadth = 5 };

            Arth<Box> arth1 = new Arth<Box>();
            var result = arth1.Add(b1,b2);
            Console.WriteLine("Hello World!");
            return;


            Box b3 = new Box { length = 4, breadth = 5 };
            Box b4 = new Box { length = 100, breadth = 100 };

            ARTH2 aRTH2 = new ARTH2();
            aRTH2.Sub(1, 1);
            aRTH2.Add(12 ,1);
            //aRTH2.d


            Circle c = new Circle { radius = 5 };
            //Your code goes here
            Console.WriteLine(c.ToString() + Environment.NewLine + b1.ToString());

            ReceiveObj(c);



            Console.WriteLine(b1 == b3);


            Arth<Box> arth = new Arth<Box>();
            Console.WriteLine(arth.Add(b1, b4));


            Arth<int> ar2 = new Arth<int>();
            Console.WriteLine(ar2.Add(5, 6));
        }


        static void ReceiveObj(object obj)
        {
            var tostring = obj.ToString();
        }
    }




    public class Box
    {
        public double length;   // Length of a box
        public double breadth;  // Breadth of a box

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            return box;
        }






        public static bool operator ==(Box b, Box c)
        {
            return (Math.Abs(b.length - c.length) < 1) && (Math.Abs(b.breadth - c.breadth) < 1);
        }

        public static bool operator !=(Box b, Box c)
        {
            return !(Math.Abs(b.length - c.length) < 1) && !(Math.Abs(b.breadth - c.breadth) < 1);
        }

        public override bool Equals(object obj)
        {
            return (Math.Abs(length - ((Box)obj).length) < 1);
        }


        public override string ToString()
        {
            return $"Box Lenght,breadth = {length},{breadth}";
        }
    }

    public class Circle 
    {
        public double radius;   // Length of a box

        // Overload + operator to add two Box objects.


        public override string ToString()
        {
            return $"Circle radius : {radius}";
        }


    }



    

    public class Arth<T>
    {
       public T Add(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
            return a + b;
        }

    }

    

    public partial class ARTH2 : IComparable
    {
        public int Add(int a, int b) => a + b;

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }


    public partial class ARTH2 : Arth<float>
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Sub(int a, int b) => a - b;
    }


}
