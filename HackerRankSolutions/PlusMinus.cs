using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class PlusMinus
    {
        public PlusMinus()
        {
            plusMinus(new List<int>() { -4, 3, -9, 0, 4, 1, });
        }

        private void plusMinus(List<int> arr)
        {
          
            double positiveRatio = 0;
            double zeroRatio = 0;
            double negativeRatio = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < 0)
                {
                    negativeRatio++;

                }else if (arr[i] == 0)
                {
                    zeroRatio++;
                }
                else
                {
                    positiveRatio++;
                }
            }

            positiveRatio = (double)positiveRatio/ arr.Count;
            negativeRatio = (double)negativeRatio / arr.Count;
            zeroRatio = (double)zeroRatio / arr.Count;

            Console.WriteLine(positiveRatio);
            Console.WriteLine(negativeRatio);
            Console.WriteLine(zeroRatio);

        }
    }
}
