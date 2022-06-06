using Microsoft.VisualStudio.TestTools.UnitTesting;
using Izzi.Noc.Services;

namespace Izzi.Noc.Test
{
    [TestClass]
    public class TemplatesServiceTest
    {
        ITemplatesServices templatesService;
        
        public TemplatesServiceTest()
        {
            templatesService = new TemplatesServiceImpl();
        }

        [TestMethod]
        public void existTemplateById_send_templatdeId_returns_true()
        {
            bool actual = templatesService.existTemplateById(1);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
