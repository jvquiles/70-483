namespace Chapter2.Objective5
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Office.Interop.Excel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_71
    {
        private interface IPlugin
        {
            string Name { get; }
            string Description { get; }
            bool Load(Application myapplication);
        }

        [TestMethod]
        public void Main() 
        {
            Assembly pluginAssembly = Assembly.Load("assemblyname");

            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;

            foreach(Type plugintype in plugins)
            {
                IPlugin plugin = Activator.CreateInstance(plugintype) as IPlugin;
            }
        }
    }
}
