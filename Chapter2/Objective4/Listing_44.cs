namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_44
    {
        private interface IAnimal 
        {
            void Move();
        }

        private class Dog : IAnimal 
        {
            public void Move() { }
            public void Bark() { }
        }

        private void MoveAnimal(IAnimal animal) 
        {
            animal.Move();
        }

        [TestMethod]
        public void Main() 
        {
            IAnimal animal = new Dog();
        }
    }
}
