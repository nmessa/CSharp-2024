//Lab Exercise 1.29.2024 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string name, ssn, userInput;
            double payRate, gross, fedTax, stateTax, net, hours;
            string strFedTax, strStateTax, strGross, strPayRate, strHours, strNet;

            //Define constants
            const double FED_TAX = 0.15;
            const double STATE_TAX = 0.05;

            //Get input from user
            //Add code here


            //Calculate gross pay
            //Add code here


            //Calculate taxes
            //Add code here


            //Calculate net pay
            //Add code here


            //Create currency strings
            //Add code here


            //Output report
            //Add code here

        }
    }
}

//Sample Output
//Enter your name: Mary Jones
//Enter your social security number: 123-45-6789
//Enter your hourly pay rate: 21.75
//Enter your hours worked: 35.5
//Payroll summary for Mary Jones
//SSN: 123-45-6789
//You worked 35.50 hours at $21.75 per hour

//Gross Pay:              $772.13
//Federal Witholding:     $115.82
//State Witholding:       $38.61
//------------------------------
//Net pay:                 $617.70
