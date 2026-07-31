using ServiceFeeCalculator.Models;

Console.WriteLine( "\tSERVICEFEECALCULATORAPP\n" );

Console.WriteLine( "\tWELCOME TO THE CAR REPAIR SERVICE!\nWHAT TYPE OF REPAIR JOB WOULD YOU " +
        "LIKE TO SCHEDULE?\n" );
string job = Console.ReadLine() ?? string.Empty;
Console.WriteLine( $"YOU HAVE SCHEDULED: {job}.\n" );

#region User imput

bool valid = false;
while ( !valid )
{
    Console.WriteLine( "ENTER TYPE OF REPAIR JOB: B/b for Basic, R/r for Regular, C/c for Complex" +
        "or type 'Q/q' to quit." );
    string prompt_1 = Console.ReadLine() ?? string.Empty;
    string userInput = prompt_1.ToLower().Trim();
    if ( userInput == "q" ) { return; }

    RepairJob? repairJob = userInput switch
    {
        "b" => new BasicRepairJob(),
        "r" => new RegularRepairJob(),
        "c" => new ComplexRepairJob(),
        _ => null
    };

    if ( repairJob != null )
    {
        Console.WriteLine(repairJob.JobDescription( job ));
        
        repairJob.JobCostDisplay();

        Console.WriteLine( $"Fee: {repairJob.CalculateFee()}€" );
        valid = true;
    }
    else
    {
        Console.WriteLine( "Invalid repair job type. Try again.\n" );
    }
}

#endregion

// TODO: Implement the logic to calculate and display the service fee based on
// the selected repair job type.