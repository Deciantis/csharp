//This program checks if a number is divisible by 7


//1) read in string
//2) convert to char[n]
//3) double last digit [(n-1)*2]
//4) convert remaining to int [(n-1)] -- This logic is flawed, I'm pretty sure of it. Moving on. Fix later.
//4) subtract it to the remaining number


//Walk through
//1) 203
//2) [2][0][3]
//3) [3]*2 = 6
//4) [2][0] = 20
//5) 20-6 = 13
//6) 13 mod 7 = 6
//7) not divisible ( 13 mod 7 must equal 0)
using System;

namespace div_by_7
{
    class Program
    {
         void Main(String[] args)
        {
            Console.WriteLine("Please enter an integer");
            doDiv(args[0]);
        }

        private int doDiv (string n){
        char[] t;
        t=n.ToCharArray();

        int x=0;        
        return x;
    }
    }





}
