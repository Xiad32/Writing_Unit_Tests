using Writing_Unit_Tests.algorithm;

namespace Writing_Unit_Tests.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Empty_Arrays()
        {
            double[] average = new double[0];
            double[] sample = new double[0];
            Assert.Throws(algorithm.AccumilateArrays(average, sample));
        }

        [Test]
        public void Test_Single_Value_Array()
        {
            double[] average = { 1 };
            double[] sample = { 1 };
            Assert.Throws(algorithm.AccumilateArrays(average, sample));
        }


        [Test]
        public void Test_Negative_Sample_Count()
        {
            double[] average = { -1, 1 };
            double[] sample = { 1, 2 };
            Assert.Throws(algorithm.AccumilateArrays(average, sample));
        }

        [Test]
        public void Test_Real_Number_Sample_Count()
        {
            double[] average = { -1.5, 1 };
            double[] sample = { 1, 2 };
            Assert.Throws(algorithm.AccumilateArrays(average, sample));
        }

        [Test]
        public void Test_Valid_Arrays()
        {
            double[] average = { 2, 1 };
            double[] sample = { 1, 4 };
            double[] result = { 3, 2 };
            Assert.Equals(algorithm.AccumilateArrays(average, sample), result);
        }
    }
}