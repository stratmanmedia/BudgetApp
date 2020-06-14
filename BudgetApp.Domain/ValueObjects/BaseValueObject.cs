using System.Collections.Generic;
using System.Linq;

namespace BudgetApp.Domain.ValueObjects
{
    public abstract class BaseValueObject
    {
        protected abstract IEnumerable<object> GetEqualityMembers();

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var valueObject = (BaseValueObject)obj;
            return GetEqualityMembers().SequenceEqual(valueObject.GetEqualityMembers());
        }

        public override int GetHashCode()
        {
            return GetEqualityMembers().Aggregate(1, (index, obj) => obj?.GetHashCode() ?? 0);
        }
    }
}