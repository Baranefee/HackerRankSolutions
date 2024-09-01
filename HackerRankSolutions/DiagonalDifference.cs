using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class DiagonalDifference
    {
        public DiagonalDifference()
        {
            List<List<int>> arr = new List<List<int>>()
            {
                new List<int>() { 1, 2, 3 },  // 0. satır
                new List<int>() { 4, 5, 6 },  // 1. satır
                new List<int>() { 7, 8, 9 }   // 2. satır

            };

            //List<List<int>> arr = new List<List<int>>()
            //{
            //    new List<int> { 1, 2, 3, 4 },
            //    new List<int> { 5, 6, 7, 8 },
            //    new List<int> { 9, 10, 11, 12 },
            //    new List<int> { 13, 14, 15, 16 }
            //};

            diagonalDifference(arr);
           
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            
            int firstDiag = 0;
            int secondDiag = 0;

            //int upperLeft = arr[0][0];
            for (int k = 0; k < arr.Count; k++)
            {
                //int temp = arr[k][k];
                //firstDiag += temp;

                firstDiag += arr[k][k];
            }

            Console.WriteLine("Right to Left Diagonal:" + firstDiag);

            //int upperRight = arr[0][arr[0].Count - 1];
            int columnIndex = arr[0].Count-1;
            for (int i = 0; i < arr.Count; i++)
            {
                //int temp = arr[i][columnCount - 1];
                //secondDiag += temp;
                //columnCount--;

                secondDiag += arr[i][columnIndex--];
            }

            Console.WriteLine("Left to Right Diagonal:" + secondDiag);

            int total = Math.Abs(firstDiag - secondDiag);
            
            Console.WriteLine("Total:" + total);
            return total;
            
        }
    }

}
