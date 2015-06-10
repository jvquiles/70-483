namespace Chapter2.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.IO;

    [TestClass]
    public class Listing_27
    {
        private void OpenConnection(DbConnection connection) 
        {
            if (connection is DbConnection)
            {

            }
        }

        private void LogStream(Stream stream) 
        {
            MemoryStream memoryStream = stream as MemoryStream;
            if (memoryStream != null) 
            {

            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
