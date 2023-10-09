using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Fredrik Nellbeck
 * .NET23_OOP
 * Systemutveckling .NET med AI-kompetens.
*/
namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            RunProgram runProgram = new RunProgram();
            runProgram.GoProgram(); // new instance variable that calls the method to run the program.
        }
    }
}
