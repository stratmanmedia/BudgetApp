namespace BudgetApp.Domain.Enumerations
{
    public class BudgetFrequency : BaseEnumeration
    {
        public static readonly BudgetFrequency Days = new BudgetFrequency(0, "Days");
        public static readonly BudgetFrequency Weeks = new BudgetFrequency(1, "Weeks");
        public static readonly BudgetFrequency Months = new BudgetFrequency(2, "Months");
        public static readonly BudgetFrequency Years = new BudgetFrequency(3, "Years");

        private BudgetFrequency(int value, string displayName) : base (value, displayName)
        {
        }
    }
}