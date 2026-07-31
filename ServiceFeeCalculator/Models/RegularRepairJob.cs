using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceFeeCalculator.Models
{
    public class RegularRepairJob : RepairJob
    {
        override public string JobDescription( string description )
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            return $"JOB: {description}.";  
        }
        // Displaying the fee for a regular repair job
        override public void JobCostDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( "REGULAR REPAIR:\r\nDone by a senior mechanic\r\n80€ per" +
                " started hour\r\nMust be paid even if repairing was not possible!" );
            Console.WriteLine( "\t--------------" );
        }
        public override decimal CalculateFee()
        {
            // Implementation for calculating fee for a regular repair job
            return 100.00m; // Example fee for regular repair job
        }
    }
}
