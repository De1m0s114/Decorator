using NUnit.Framework;
using  ConsoleApp1;
using System;
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
            var s = new SecondLesson(new FirstLesson());
            var p = s.GoLesson();
            var j = "Go 1 lessonGo 2 lesson";
            Assert.AreEqual(j, p);
        }
       

        [Test]
        public void FinalTest()
        {
            var s = new ThirdLesson(new SecondLesson(new FirstLesson()));
            var p = s.GoLesson();
            var j = "Go 1 lessonGo 2 lessonGo 3 lesson";


            Assert.AreEqual(j, p);
           
        }

    }
}