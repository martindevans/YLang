using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YParser;
using YTest.Extensions;

namespace YTest.Parsing
{
    [TestClass]
    public class StructTests
    {
        [TestMethod]
        public void Empty()
        {
            var p = Parser.ParseProgram("struct hello { }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Structs.Count);
            Assert.AreEqual("hello", p.Ok.Structs.Single().Name.Path.Single());
            Assert.AreEqual(0, p.Ok.Structs.Single().Fields.Count);
        }

        [TestMethod]
        public void WithField()
        {
            var p = Parser.ParseProgram("struct hello { a:number }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Structs.Count);
            Assert.AreEqual("hello", p.Ok.Structs.Single().Name.Path.Single());
            Assert.AreEqual(1, p.Ok.Structs.Single().Fields.Count);
        }

        [TestMethod]
        public void WithFields()
        {
            var p = Parser.ParseProgram("struct hello { a:number, b:number }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Structs.Count);
            Assert.AreEqual("hello", p.Ok.Structs.Single().Name.Path.Single());
            Assert.AreEqual(2, p.Ok.Structs.Single().Fields.Count);
        }
    }
}
