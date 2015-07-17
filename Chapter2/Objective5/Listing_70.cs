namespace Chapter2.Objective5
{
    using Microsoft.Office.Interop.Excel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_70
    {
        private interface IPlugin
        {
            string Name { get; }
            string Description { get; }
            bool Load(Application myapplication);
        }

        private class MyPlugin : IPlugin     
        {
            public string Name 
            {
                get 
                {
                    return "My Plugin";
                }
            }

            public string Description             
            {
                get 
                {
                    return "My sample Plugin";
                }
            }

            public bool Load(Application application) 
            {
                return true;
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
