using System;
using System.Collections.Generic;

namespace BudgetApp.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public long? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<Category> Subcategories { get; set; }

        public Category()
        {
            Subcategories = new HashSet<Category>();
        }
    }
}