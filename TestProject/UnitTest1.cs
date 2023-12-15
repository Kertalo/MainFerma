using Microsoft.VisualStudio.TestPlatform.TestHost;
using Ferma;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Ferma.Program.Ferma(2, out int _, out int _, out int _));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(!Ferma.Program.Ferma(3, out int _, out int _, out int _));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(!Ferma.Program.Ferma(-1, out int _, out int _, out int _));
        }
    }
}