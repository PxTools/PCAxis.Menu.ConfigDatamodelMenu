using PCAxis.Menu.Implementations;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PCAxis.Menu.Configuration;
using System.Xml;
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PCAxis.Menu.Implementations.Tests
{
    [TestClass()]
    public class ConfigDatamodelMenuTest
    {
        [TestMethod()]
        public void DatamodelPluginConfigurationSectionCreateTest()
        {
            var Method = new DatamodelPluginConfigurationSection();

            var parent = new object();
            var configContext = new  object();
            
            DataSet ds = new DataSet();

           
            var section = new XmlDataDocument(ds);


            var test = Method.Create(parent, configContext, section);
            
            Assert.IsNotNull(test);
        }
        
    }

}
