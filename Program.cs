using System;

namespace Test {

    class Program {
        public static void Main(string[] args)
        {
            Point x;
            x.X = 10;
            x.Y = 11;
            Console.WriteLine(x.ToString());

        }

    }

    struct Point {
        public int X;
        public int Y;

        public override string ToString(){
            return string.Format("X = {0}, Y = {1}", X,Y);
        }
    }

}
