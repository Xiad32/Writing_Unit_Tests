using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_Unit_Tests
{
    public class Algorithm
    {

        public class AverageArrayStructure
        {
            public float[] Average { get; set; }
            public int SamplesAveraged { get; set; }

            public AverageArrayStructure(float[] averageSamples, int samplesAveraged)
            {
                Average = averageSamples;
                SamplesAveraged = samplesAveraged;
            }
        }

        // This method takes two arrays, an average array, and a new sample array
        // The new sample is divided by the number of samples collected so far
        // The average array is multiplied by the samples collected number
        // Then added together into a new array and divided by samples collected number
        // The first element of average is always equal to the average_count
        // The samples collected number is stored as the first element of the average array
        static public void IncrementalAverage(AverageArrayStructure averageSamples,  float[] newSample)
        {
            if (averageSamples.Average.Length != newSample.Length)
            {
                throw new Exception("Sample & Samples Average should be of the same length");
            }

            if (averageSamples.SamplesAveraged < 1)
            {
                throw new Exception("Samples averaged cannot be less than one");
            }

            for (int i=0; i<averageSamples.Average.Length; i++)
            {
                newSample[i] = newSample[i] / (averageSamples.SamplesAveraged + 1);
                averageSamples.Average[i] = averageSamples.Average[i] * averageSamples.SamplesAveraged;
                averageSamples.Average[i] = (newSample[i] + averageSamples.Average[i]) / (averageSamples.SamplesAveraged + 1);
            }

            averageSamples.SamplesAveraged++; 

        }

    }
}
