namespace Chapter2.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Diagnostics;

    [TestClass]
    public class Listing_62
    {
        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        static void MyMethod() { }

        [TestMethod]
        public void Main() 
        {            
            ConditionalAttribute conditionaAttribute =
                (ConditionalAttribute)Attribute.GetCustomAttribute(
                    typeof(Listing_62),
                    typeof(ConditionalAttribute));

            string condition = conditionaAttribute.ConditionString;

            Console.WriteLine(condition);
        }
    }
}