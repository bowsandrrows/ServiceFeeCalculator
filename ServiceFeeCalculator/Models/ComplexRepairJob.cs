using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceFeeCalculator.Models
{
    public class ComplexRepairJob : RepairJob
    {
        override public string JobDescription( string description )
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            return $"JOB: {description}.";
        }
        override public void JobCostDisplay()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine( "COMPLEX REPAIR:\r\nDone by a master mechanic\r\n500€ if " +
                "repaired within four hours (no rounding to full hours)\r\nFlat fee of 800€ " +
                "if it takes longer\r\nNothing is to pay if repairing was not possible" );
            Console.WriteLine( "\t--------------" );
        }
        public override decimal CalculateFee()
        {
            // Implementation for calculating fee for a complex repair job
            return 200.00m; // Example fee for complex repair job
        }
    }       
}
