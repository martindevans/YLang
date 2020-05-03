using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YParser;
using YTest.Extensions;

namespace YTest.Parsing
{
    [TestClass]
    public class ImportTests
    {
        [TestMethod]
        public void BasicImport()
        {
            var p = Parser.ParseProgram("import \"hello\";");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Imports.Count);
            Assert.AreEqual("hello", p.Ok.Imports.Single().Path);
            Assert.AreEqual(null, p.Ok.Imports.Single().NameSpace);
        }

        [TestMethod]
        public void ImportWithNamespace()
        {
            var p = Parser.ParseProgram("import \"hello\" in world;");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Imports.Count);
            Assert.AreEqual("hello", p.Ok.Imports.Single().Path);
            Assert.AreEqual("world", p.Ok.Imports.Single()?.NameSpace?.Path.Single());
        }
    }
}
