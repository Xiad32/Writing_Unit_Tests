using Writing_Unit_Tests;
using static Writing_Unit_Tests.Algorithm;

namespace Unit_Tests.Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new float[] { 1, 1 }, 1, new float[] { 1, 1, 2 })]
        public void Test_Input_Structure_Exceptions(float[] average, int samplesAveraged, float[] sample)
        {
            AverageArrayStructure inputData = new AverageArrayStructure(average, samplesAveraged);
            Assert.Throws<Exception>(() => IncrementalAverage(inputData, sample));
        }


        [Test]
        [TestCase(new float[] { 1 }, -1, new float[] { 2 })]
        public void Test_Invalid_Samples_Count(float[] average, int samplesAveraged, float[] sample)
        {
            AverageArrayStructure data = new AverageArrayStructure(average, samplesAveraged);
            Assert.Throws<Exception>(() => IncrementalAverage(data, sample));
        }

        [Test]
        public void Test_Valid_Arrays()
        {
            AverageArrayStructure data = new AverageArrayStructure(new float[] { 1 }, 2);
            float[] sample = { 4 };
            AverageArrayStructure result = new AverageArrayStructure( new float[] { 1.11111116f }, 3);
            IncrementalAverage(data, sample);
            Assert.That(result.Average, Is.EqualTo(data.Average));
            Assert.That(result.SamplesAveraged, Is.EqualTo(data.SamplesAveraged));
        }
    }
}