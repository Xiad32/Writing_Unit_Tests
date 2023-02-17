using Writing_Unit_Tests;

namespace Unit_Tests.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new float[0], new float[0])]
        [TestCase(new float[] {1}, new float[] { 1 })]
        [TestCase(new float[] { 1, 1, 1 }, new float[] { 1, 2 })]
        public void Test_Input_Structure_Exceptions(float[] average, float[] sample)
        {
            Assert.Throws<Exception>(() => Algorithm.AccumilateArrays(average, sample));
        }


        [Test]
        [TestCase(new float[] { -1, 1 }, new float[] { 1, 2 })]
        [TestCase(new float[] { (float)-1.5, 1 }, new float[] { 1, 2 })]
        public void Test_Invalid_Samples_Count(float[] average, float[] sample)
        {
            Assert.Throws<Exception>(() => Algorithm.AccumilateArrays(average, sample));
        }

        [Test]
        public void Test_Valid_Arrays()
        {
            float[] average = { 2, 1 };
            float[] sample = { 1, 4 };
            float[] result = { 3, 1.11111116f };
            Assert.That(result, Is.EqualTo(Algorithm.AccumilateArrays(average, sample)));
        }
    }
}