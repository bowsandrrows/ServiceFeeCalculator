namespace ServiceFeeCalculator.Models
{
    public abstract class RepairJob
   {

        string Description { get; set; } = "";
        DateTime Start { get; set; }
        DateTime End { get; set; }
        bool IsCompleted { get; set; }

        // Tipp: All repair costs depend on the duration in hours.
        // JobCostDisplay() - Displays the fee for the repair job.
        public abstract void JobCostDisplay();

        // param "description" => The description text to assign to the job.
        // The assigned description.
        public abstract string JobDescription(string description );

        // Abstract method to calculate the fee for the repair job. Must be implemented by
        // derived classes.
        public abstract decimal CalculateFee();

    }
}
