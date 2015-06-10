namespace Chapter2.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Dynamic;

    [TestClass]
    public class Listing_29
    {
        private class SampleObject : DynamicObject 
        {
            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                result = binder.Name;
                return true;
            }
        }

        [TestMethod]
        public void Main() 
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SomeProperty);
        }
    }
}
