using NUnit.Framework;
using Code_Exam;

namespace ExamUnitTest
{
    [TestFixture]
    public class ExamUnitTests
    {
        private Exam _exam;

        [SetUp]
        public void Setup()
        {
            _exam = new Exam();
        }

        [Test]
        public void Test1()
        {
            string actual = _exam.ParseAndReplace("Hello-theerre Hunnter goodbye");
            string expected = "H2o-t3e H4r g4e";
            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            string actual = _exam.ParseAndReplace("Hello-theerre5Hunnter goodbye");
            string expected = "H2o-t3e5H4r g4e";
            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            string actual = _exam.ParseAndReplace("Hello theerre5Hunnter goodbye");
            string expected = "H2o t3e5H4r g4e";
            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }
        [Test]
        public void Test4()
        {
            string actual = _exam.ParseAndReplace("Hi theerre_Hunnter'sgoodbye");
            string expected = "H0i t3e_H4r's5e";
            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }
        [Test]
        public void Test5()
        {
            string actual = _exam.ParseAndReplace("Smooth");
            string expected = "S3h";
            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }
    }
}