using System;

namespace Test {

    class Program {
        public static void Main(string[] args)
        {

            //Point x = new Point(10,11);
            //Console.WriteLine(x.ToString());

            Point y = new Point();
            Console.WriteLine(y.ToString());

        }

    }

    readonly struct Point {
        //public readonly int X;
        
        //public readonly int Y;
        public int X {get;}
        public int Y {get;}

        public override string ToString(){
            return string.Format("X = {0}, Y = {1}", X,Y);
        }

        public Point() {
            X = 1;
            Y = 1;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

}
