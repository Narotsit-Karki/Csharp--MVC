// See https://aka.ms/new-console-template for more information
using ConsoleApp;

List<Rectangle> rects = new List<Rectangle>() { 
    new Rectangle(12,12),
    new Rectangle(12,13),
    new Rectangle(15,12)
    
};

foreach(var rect in rects)
{
    Console.WriteLine($"[*] {rect.CalculateArea()}");
}
namespace ConsoleApp{ 

    abstract class Shape
    {
        public abstract float CalculateArea();
    }

    class Rectangle : Shape
    {
        public int width;
        public int height;
        public Rectangle(int w,int h)
        {
            this.width = w;
            this.height = h;
        }

        public override float CalculateArea()
        {
            return this.width * this.height;
        }
    }
    class Triangle: Shape
    {
        public int base_length;
        public int height;

        public Triangle(int b,int h)
        {
            this.base_length = b;
            this.height = h;
        }

        public override float CalculateArea()
        {
            return 1 / 2 * this.base_length * this.height;
        }
    }
}

