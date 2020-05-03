using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YGrammar;
using YParser;
using YTest.Extensions;

namespace YTest.Parsing
{
    [TestClass]
    public class CallableTests
    {
        [TestMethod]
        public void SimpleProc()
        {
            var p = Parser.ParseProgram("proc hello() { body:todo }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Callables.Count);
            Assert.AreEqual("hello", p.Ok.Callables.Single().Name.Path.Single());
            Assert.IsNull(p.Ok.Callables.Single().ReturnType);
            Assert.AreEqual(CallType.Goto, p.Ok.Callables.Single().CallType);
        }

        [TestMethod]
        public void SimpleMacro()
        {
            var p = Parser.ParseProgram("macro hello() { body:todo }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Callables.Count);
            Assert.AreEqual("hello", p.Ok.Callables.Single().Name.Path.Single());
            Assert.IsNull(p.Ok.Callables.Single().ReturnType);
            Assert.AreEqual(CallType.Inline, p.Ok.Callables.Single().CallType);
        }

        [TestMethod]
        public void ProcWithReturn()
        {
            var p = Parser.ParseProgram("proc hello() -> world { body:todo }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Callables.Count);
            Assert.AreEqual("hello", p.Ok.Callables.Single().Name.Path.Single());
            Assert.AreEqual("world", p.Ok.Callables.Single().ReturnType?.Path.Single());
            Assert.AreEqual(CallType.Goto, p.Ok.Callables.Single().CallType);
        }

        [TestMethod]
        public void MacroWithReturn()
        {
            var p = Parser.ParseProgram("macro hello() -> world { body:todo }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Callables.Count);
            Assert.AreEqual("hello", p.Ok.Callables.Single().Name.Path.Single());
            Assert.AreEqual("world", p.Ok.Callables.Single().ReturnType?.Path.Single());
            Assert.AreEqual(CallType.Inline, p.Ok.Callables.Single().CallType);
        }

        [TestMethod]
        public void ProcWithArgs()
        {
            var p = Parser.ParseProgram("proc hello(a:b, copy c:d) { body:todo }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Callables.Count);
            Assert.AreEqual(2, p.Ok.Callables.Single().Parameters.Count);
            Assert.AreEqual("a", p.Ok.Callables.Single().Parameters[0].Field.Name.Path.Single());
            Assert.AreEqual("b", p.Ok.Callables.Single().Parameters[0].Field.Type.Path.Single());
            Assert.IsFalse(p.Ok.Callables.Single().Parameters[0].Copy);
            Assert.IsTrue(p.Ok.Callables.Single().Parameters[1].Copy);
        }

        [TestMethod]
        public void MacroWithArgs()
        {
            var p = Parser.ParseProgram("macro hello(a:b, copy c:d) { body:todo }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Callables.Count);
            Assert.AreEqual(2, p.Ok.Callables.Single().Parameters.Count);
            Assert.AreEqual("a", p.Ok.Callables.Single().Parameters[0].Field.Name.Path.Single());
            Assert.AreEqual("b", p.Ok.Callables.Single().Parameters[0].Field.Type.Path.Single());
            Assert.IsFalse(p.Ok.Callables.Single().Parameters[0].Copy);
            Assert.IsTrue(p.Ok.Callables.Single().Parameters[1].Copy);
        }

        [TestMethod]
        public void Contracts()
        {
            var p = Parser.ParseProgram("macro hello() requires expr:todo; ensures expr:todo; { body:todo }");

            Assert.That.IsTrue(p.IsOk, () => p.Err.ToString());
            Assert.AreEqual(1, p.Ok.Callables.Count);
            Assert.AreEqual(2, p.Ok.Callables.Single().Contracts.Count);
        }
    }
}
