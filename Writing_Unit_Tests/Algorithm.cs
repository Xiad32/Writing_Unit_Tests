using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_Unit_Tests
{
    public class Algorithm
    {
        // This method takes two arrays, an average array, and a new sample array
        // The new sample is divided by the number of samples collected so far
        // The average array is multiplied by the samples collected number
        // Then added together into a new array and divided by samples collected number
        // The first element of average is always equal to the average_count
        // The samples collected number is stored as the first element of the average array
        static public float[] AccumilateArrays(float[] average,  float[] sample)
        {
            float samples_collected = average[0];

            float[] res = new float[average.Length];

            for (int i=1; i<average.Length; i++)
            {
                sample[i] = sample[i] / (samples_collected + 1);
                average[i] = average[i] * samples_collected;
                res[i] = (sample[i] + average[i]) / (samples_collected + 1);
            }

            res[0] = samples_collected + 1; 

            return res;

        }

    }
}
