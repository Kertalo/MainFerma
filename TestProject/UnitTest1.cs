using Ferma;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Ferma.Program.Ferma(2, out int _, out int _, out int _));
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(!Ferma.Program.Ferma(3, out int _, out int _, out int _));
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(!Ferma.Program.Ferma(-1, out int _, out int _, out int _));
        }
    }
}