using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace Laison.Lapis.Prepayment.Domain.ValueObjects
{
    /// <summary>
    /// 金额
    /// </summary>
    public class MoneyAmount : ValueObject
    {
        public double Amount { get; private set; }

        public Currency Currency { get; private set; }

        private MoneyAmount()
        {
        }

        public MoneyAmount(double amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Amount;
            yield return Currency;
        }
    }

    /// <summary>
    /// 币种
    /// </summary>
    public enum Currency
    {
        RMB = 1,
        Dollar = 2,
    }
}