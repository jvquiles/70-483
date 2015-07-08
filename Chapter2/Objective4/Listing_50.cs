namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_50
    {
        private class Rectangle
        {
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public int Height { get; set; }
            public int Width { get; set; }
            public int Area
            {
                get
                {
                    return Height * Width;
                }
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
