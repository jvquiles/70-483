namespace Chapter2.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_40
    {
        private interface ILeft 
        {
            void Move();
        }

        private interface IRight 
        {
            void Move();
        }

        private class MoveableObject : ILeft, IRight 
        {
            void ILeft.Move() { }
            void IRight.Move() { }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
