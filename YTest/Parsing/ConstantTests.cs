using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YGrammar.Expressions;
using YParser;
using YTest.Extensions;

namespace YTest.Parsing
{
    [TestClass]
    class ConstantTests
    {
        [TestMethod]
        public void SimpleAssignment()
        {
            var p = Parser.ParseProgram("const hello:world = 1");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Constants.Count);
            Assert.AreEqual("hello", p.Ok.Constants.Single().Field.Name);
            Assert.AreEqual("world", p.Ok.Constants.Single().Field.Type.Path.Single());
            Assert.AreEqual(new ConstNumber(1), p.Ok.Constants.Single().Expression);
        }

        [TestMethod]
        public void ComplexAssignment()
        {
            var p = Parser.ParseProgram("constant hello:world = 3 * 4 + 5 / 6");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Constants.Count);
            Assert.AreEqual("hello", p.Ok.Constants.Single().Field.Name);
            Assert.AreEqual("world", p.Ok.Constants.Single().Field.Type.Path.Single());
            Assert.AreEqual(new ConstNumber(1), p.Ok.Constants.Single().Expression);
        }
    }
}
