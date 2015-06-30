namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_47
    {
        private class Base
        {
            protected virtual void Execute() {}
        }

        private class Derived : Base
        {
            protected override void Execute()
            {
                this.Log("Before executing");
                base.Execute();
                this.Log("After executing");
            }

            private void Log(string message)
            {

            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
