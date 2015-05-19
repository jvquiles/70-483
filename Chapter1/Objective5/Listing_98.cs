namespace Chapter1.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Runtime.Serialization;

    [TestClass]
    public class Listing_98
    {
        [Serializable]
        private class OrderProcessingException : Exception, ISerializable
        {
            public int OrderId { get; private set; }

            public OrderProcessingException(int orderId)
            {
                this.OrderId = orderId;
                this.HelpLink = "http://www.mydomain.com/infoaboutexception";
            }

            public OrderProcessingException(int orderId, string message)
                : base(message)
            {
                this.OrderId = orderId;
                this.HelpLink = "http://www.mydomain.com/infoaboutexception";
             }

            public OrderProcessingException(int orderId, string message, Exception innerException)
                : base(message, innerException)
            {
                this.OrderId = orderId;
                this.HelpLink = "http://www.mydomain.com/infoaboutexception";
            }

            protected OrderProcessingException(SerializationInfo info, StreamingContext context) 
            {
                this.OrderId = (int)info.GetValue("OrderId", typeof(int));
            }

            public override void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("OrderId", typeof(int));
            }
        }

        [TestMethod]
        public void Main() 
        {
            
        }
    }
}
