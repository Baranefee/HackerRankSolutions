using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class Encryption
    {
        public Encryption()
        {
            encryption("feedthedog");
        }

        public void encryption(string s)
        {
            //string noWhiteSpace = s.Replace(" ", "");
           var deneme =  Math.Sqrt(s.Length);
            int row = (int)Math.Floor(deneme);
            int column = (int)Math.Ceiling(deneme);
            int[,] dizi = new int[row, column];



        }
    }
}
