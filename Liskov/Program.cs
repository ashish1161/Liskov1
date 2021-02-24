using System;

namespace Liskov
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(int width ,int height)
        {
            Width = width;
            Height = height;
        }
        public override string ToString()
        {
            return $"{nameof(Width)} : {Width}, {nameof(Height)} : {Height}";
        }
    }
    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
        public override  int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
    class Program
    {
        public static int Area(Rectangle r) => r.Height * r.Width;  
        static void Main(string[] args)
        {
            Rectangle re = new Rectangle(5,8);
            Console.WriteLine($"{re} has area {Area(re)}");

            Rectangle sq = new Square();
            sq.Height = 9;
            Console.WriteLine($"{sq} has area {Area(sq)}");


        }
    }
}
