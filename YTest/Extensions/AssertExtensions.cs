using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YTest.Extensions
{
    public static class AssertExtensions
    {
        public static void IsTrue(this Assert assert, bool condition, Func<string> failureMessage)
        {
            if (condition)
                Assert.IsTrue(true);
            else
                Assert.Fail(failureMessage());
        }
    }
}
