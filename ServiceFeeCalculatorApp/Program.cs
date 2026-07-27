using ServiceFeeCalculator.Models;

Console.WriteLine( "\tSERVICEFEECALCULATORAPP\n" );

Console.WriteLine( "ENTER THE JOB TO BE DONE\n> " );
string job = Console.ReadLine() ?? string.Empty;
RepairJob? typeOfJob = null;
Console.WriteLine( typeOfJob?.JobDescription( job ) );

#region User imput

bool valid = false;
while ( !valid )
{
    Console.WriteLine( "Enter type of repair job: B/b for Basic, or type 'Q/q' to quit." +
        "R/r for Regular, C/c for Complex" );
    string prompt = Console.ReadLine() ?? string.Empty;
    string userInput = prompt.ToLower().Trim();
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