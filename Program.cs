using System.Linq;
using System.Collections.Generic;
using System;

namespace Customer
{
    class Program
    {
        static int arraySize = 16;
        static void Main(string[] args)
        {
            double  sum = 0;
            for(int i=arraySize/2; i<3*arraySize/4-1;i++){
                sum+= getElem(i);
            }
            Console.WriteLine(sum);
            
        }
        static double  getElem(int i){
            double arraySizeDouble = arraySize*1.0;
            double elem = (i+Math.Sqrt(arraySizeDouble)+Math.Pow(i, 1/arraySizeDouble))
                          /(Math.Sqrt(i*arraySizeDouble+arraySizeDouble));
            return elem;
        }
        static String Test(){
            return "Test";
        }
    }
    
    class CaseInsensitiveComparer : IComparer<string>{
        public int Compare(string x, string y){
            return string.Compare(x,y,StringComparison.OrdinalIgnoreCase);
        }
    }
}
