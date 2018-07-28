using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Solution
    {
        public static int Gap(string binaryNumber)
        {
            int maxgap = 0;
            int gap = 0;
            for (var i = 0; i < binaryNumber.Length; i++)
            {

                if (binaryNumber[i] == '0')    
                        { 
                            gap++;
                            
                        } else
                        {
                        if (maxgap < gap)
                            {
                                maxgap = gap;
                            }
                        gap = 0;
                        }
                
                //Console.WriteLine(binaryNumber[i]);
            }
            return maxgap;
        }
    }
}
