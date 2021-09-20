using Xunit;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
    public class AboutBitwiseAndShiftOperator : Koan
    {
        [Step(1)]
        public void BinaryAndOperator()
        {
            //Example
            //1 in binary is 0001
            //3 in binary is 0011
            //With & only taking the same one else take 0,so 1 & 3 it becomes 0001. (What??)
            //When 0001 convert to int it becomes 1

            //My explanation::

            // uint a = 0b_1111_1000;
            // uint b = 0b_1001_1101;
            // uint c = a & b;

            //Output:
            //10011000

            //So lined up
            // a : 1|1|1|1|_|1|0|0|0
            // b : 1|0|0|1|_|1|1|0|1

            // c : 1|0|0|1| |1|0|0|0

            //if we use & operator, both values in the same column must be 1 to return 1.
            //Otherwise, will return 0.


            int x = 4 & 4;

            //The result will be 4, as 4 in bit is 0100 so:
            //0|1|0|0 - first 4
            //0|1|0|0 - second 4
            //0|1|0|0 - result


            Assert.Equal(4, x);
        }

        [Step(2)]
        public void BinaryOrOperator()
        {
            //Example
            //1 in binary is 0001
            //3 in binary is 0011
            //With | it will take any 1 if either one contains 1, so 1 | 3 it becomes 0011.
            //When 0011 convert to int it becomes 3
            int x = 4 | 4;

            //0|1|0|0 - first 4
            //0|1|0|0 - second 4
            //0|1|0|0 - result

            Assert.Equal(4, x);
        }

        [Step(3)]
        public void BinaryXOrOperator()
        {
            //Example
            //1 in binary is 0001
            //3 in binary is 0011
            //With ^ it will take 1 when it is 0-1, if it is 1-1 it will take 0,so 1 & 3 it becomes 0010.
            //When 0010 convert to int it becomes 2
            int x = 4 ^ 4;

            //0|1|0|0 - first 4
            //0|1|0|0 - second 4
            //0|0|0|0 - result

            Assert.Equal(0, x);
        }

        [Step(4)]
        public void BinaryOnesComplementOperator()
        {
            //Example
            //With ~ it will convert positive number to negative number and add -1 to the number.
            // ~1 become -2
            int x = ~4;

            Assert.Equal(-5, x);
        }

        [Step(5)]
        public void Combination1()
        {
            int x = ~3 & 8;

            Assert.Equal(8, x); //(Don't understand how the negative numbers work in bit -- to look up
        }

        [Step(6)]
        public void Combination2()
        {
            int x = 4 | 4 & 8;

            //0|1|0|0 - first 4
            //0|1|0|0 - second 4
            //1|0|0|0 - third 8
            //0|1|0|0 - result (because & is performed first, then |?)

            Assert.Equal(4, x);
        }

        [Step(7)]
        public void Combination3()
        {
            int x = 3 & 4 ^ 4 & ~8;

            Assert.Equal(4, x);
        }

        [Step(8)]
        public void BitwiseLeftShift()
        {
            //Example
            //4 in binary is 0100
            //when we try to 4 << 1
            //it becomes 1000
            //then it will become 8
            int x = 10 << 2;

            //32|16|8|4|2|1

            //0 |0 |1|0|1|0 - 10

            //1 |0 |1|0|0|0 - 40

            Assert.Equal(40, x);
        }

        [Step(9)]
        public void BitwiseRightShift()
        {
            //Example
            //4 in binary is 0100
            //when we try to 4 >> 1
            //it becomes 0010
            //then it will become 2
            int x = 12 >> 2;

            //32|16|8|4|2|1

            //0 |0 |1|1|0|0 - 12

            //0 |0 |0|0|1|1 - 3

            Assert.Equal(3, x);
        }

        [Step(10)]
        public void Combination4()
        {
            int x = (5 << 2) & 8 ^ 3;

            Assert.Equal(3, x);
        }

        [Step(11)]
        public void Combination5()
        {
            int x = (5 >> 2) & (~8) ^ 8;

            Assert.Equal(9, x);
        }

        [Step(12)]
        public void Combination6()
        {
            int x = (8 << 2) & (~5) & 8 | 10 | (5 >> 1);

            Assert.Equal(10, x);
        }

        [Step(13)]
        public void AdditionWithoutPlusOrMinusOperator()
        {
            //Solve this problem without using + or -
            //This is a complicated problem. If you don't 
            //know how to solve it, try to Google it.

            //32|16|8|4|2|1

            //0 |0 |1|1|1|1 - 15
            //0 |0 |0|1|0|0 - 4
            //0 |1 |0|0|1|1 - 19

            int a = 15;
            int b = 4;

            //Here goes your implementation to set value to FILL_ME_IN
            //Assert.Equal(FILL_ME_IN, 19); solve later :S
        }
    }
}