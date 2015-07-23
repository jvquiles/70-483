namespace Chapter2.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq.Expressions;

    [TestClass]
    public class Listing_78
    {
        [TestMethod]
        public void Main() 
        {
            BlockExpression blockExpr = Expression.Block(
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("Write", new Type[] { typeof(string) }),
                    Expression.Constant("Hello ")),
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }),
                    Expression.Constant("World!"))
                    );

            Expression.Lambda<Action>(blockExpr).Compile();
        }
    }
}
