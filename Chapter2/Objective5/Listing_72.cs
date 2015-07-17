namespace Chapter2.Objective5
{
    using System;
    using System.Reflection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_72
    {
        static void DumpObject(object obj) 
        {
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo field in fields) 
            {
                if (field.FieldType == typeof(int)) 
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }
        }

        [TestMethod]
        public void Main()
        {

        }
    }
}
