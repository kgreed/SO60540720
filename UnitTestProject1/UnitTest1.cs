using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var o = new myframeworklib.FrameworkKittens();
            var n = o.GetKittenCount();  // will error see https://stackoverflow.com/questions/60217182/could-not-load-file-or-assembly-microsoft-extensions-dependencyinjection-abstra
        }
    }
}
