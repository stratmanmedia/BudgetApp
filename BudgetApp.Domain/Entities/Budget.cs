namespace BudgetApp.Domain.Entities
{
    public class Budget : BaseEntity
    {
        public string Name { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public long Amount { get; set; }
        public long Frequency { get; set; }
        public int Interval { get; set; }
    }
}
