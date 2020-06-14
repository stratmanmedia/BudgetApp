using System;

namespace BudgetApp.Domain.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
