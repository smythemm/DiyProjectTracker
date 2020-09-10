namespace DiyProjectTracker.Data
{
    public class DiyProject
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public string ClientName { get; set; }

        public int EstimatedDaysToComplete { get; set; }
    }
}