using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDPractice
{
    public class Calculator
    {
        public int Parse(int[] temp)
        {
            int count  =0;
            var sortData = temp.Reverse().ToList();


            for (int i = 0; i < sortData.Count; i++)
            {
                count += sortData[i] * (int)Math.Pow(2, i); ;
            }
         
            return count;
        }   
    }
}
