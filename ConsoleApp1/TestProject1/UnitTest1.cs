using NUnit.Framework;
using  ConsoleApp1;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestForFirstLesson()
        {
            var s = new FirstLesson();
            var p = s.GoLesson();
            var j = "Go 1 lesson";
            Assert.AreEqual(j, p);
        }
        [Test]
        public void TestForSecondLesson()
        {
            var s = new SecondLesson();
            var p = s.GoLesson();
            var j = "Go 2 lesson";
            Assert.AreEqual(j, p);
        }
        [Test]
        public void TestForThirdLesson()
        {
            var s = new ThirdLesson();
            var p = s.GoLesson();
            var j = "Go 3 lesson";
            Assert.AreEqual(j, p);
        }
       
    }
}