using System;
using System.Collections.Generic;

namespace BudgetApp.Domain.ValueObjects
{
    public class Money : BaseValueObject
    {
        public long Cents { get; }
        public string Currency { get; }
        public decimal Dollars => ConvertCentsToDollars(Cents);

        public Money(long cents, string currency)
        {
            Cents = cents;
            Currency = currency;
        }

        public Money(decimal dollars, string currency)
        {
            Cents = ConvertDollarsToCents(dollars);
            Currency = currency;
        }

        protected override IEnumerable<object> GetEqualityMembers()
        {
            yield return Cents;
            yield return Currency;
        }

        private long ConvertDollarsToCents(decimal dollars)
        {
            var multiplied = Math.Floor(dollars * 100);
            var cents = Convert.ToInt64(multiplied);
            return cents;
        }

        private decimal ConvertCentsToDollars(long cents)
        {
            var dCents = Convert.ToDecimal(cents);
            var divided = Math.Floor(dCents) / 100;
            return divided;
        }
    }
}