using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceFeeCalculator.Models
{
    public class BasicRepairJob : RepairJob
    {
        override public string JobDescription( string description )
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            return $"JOB: {description}.";
        }
        override public void JobCostDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "BASIC REPAIR:\r\nDone by a junior mechanic\r\n15€ per " +
                "started hour (e.g. 1 hour 15 minutes mean 30€)" );
            Console.WriteLine( "\t--------------" );
        }
        public override decimal CalculateFee()
        {
            // For a basic repair job, the fee is a fixed amount
            return 50.00m; // Fixed fee for basic repair job
        }
    }
}
