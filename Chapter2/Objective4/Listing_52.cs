namespace Chapter2.Objective4
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_52
    {
        private class Rectangle
        {
            public Rectangle() { }

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public virtual int Height { get; set; }
            public virtual int Width { get; set; }
            public int Area
            {
                get
                {
                    return Height * Width;
                }
            }
        }

        private class Square : Rectangle
        {
            public override int Width
            {
                get
                {
                    return base.Width;
                }
                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }

            public override int Height
            {
                get
                {
                    return base.Height;
                }
                set
                {
                    base.Height = value;
                    base.Width = value;
                }
            }
        }

        [TestMethod]
        public void Main()
        {
            Rectangle rectangle = new Square();
            rectangle.Width = 10;
            rectangle.Height = 5;
            Console.WriteLine(rectangle.Area);
        }
    }
}
