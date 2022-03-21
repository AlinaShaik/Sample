using NUnit.Framework;
using Task1;

namespace TestP
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_Load()
        {
            WebForm1 wf = new WebForm1();
            
            Assert.Pass();
        }
    }
}