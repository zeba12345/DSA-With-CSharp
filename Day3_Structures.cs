using System;
class HelloWorld
{
    struct Rectangle
    {
        public int Length;
        public int Breadth;
    }

    static int Area(Rectangle r)
    {
        int a = r.Length * r.Breadth;
        return a;
    }
    static void Main()
    {

        Rectangle rect;
        rect.Length = 10;
        rect.Breadth = 3;
        int a = Area(rect);
        Console.WriteLine(a);
    }
}