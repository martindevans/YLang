using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YParser;

namespace YTest
{
    [TestClass]
    public class Playground
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var txt = await File.ReadAllTextAsync("Scripts/all.y");
            var p = Parser.ParseProgram(txt);

            if (!p.IsOk)
                Assert.Fail(p.Err.ToString());
            else
                Assert.IsTrue(p.IsOk);
        }
    }
}
