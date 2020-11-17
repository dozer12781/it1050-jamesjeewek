using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
/* 1. a controlled variable ( or loop counter)
 * 2. The initial value of the controlled variable.
 * 3. The increment (or decrement) by which the control variable is modified each time through the loop.
 * 4. The loop-continuation condition that determines if looping should continue.*/

/* The while statement can be used to implement any counter controlled loop but the for repetition statement is for specifying the counter controlled repetition detail in a single line of code.
The for statements are used for counter controlled repetition and the while statements for sentinel controlled repetition.
Both the while and for can each be used for either repetition type.*/

/* Use do..while instead of while when a set of instructions and or block of statements that need to executed at least once.
Example: Need to input the set of integers in range 1 through 10 and to find cumulative sum.*/

int counter = 1; //