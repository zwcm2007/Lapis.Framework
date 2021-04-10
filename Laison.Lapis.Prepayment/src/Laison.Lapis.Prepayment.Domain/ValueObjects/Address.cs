using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace Laison.Lapis.Prepayment.Domain.ValueObjects
{
    /// <summary>
    /// 地址
    /// </summary>
    public class Address : ValueObject
    {
        public string Province { get; private set; }

        public string City { get; private set; }

        public string Town { get; private set; }

        public string Village { get; private set; }

        private Address()
        {
        }

        public Address(string province, string city, string town, string village)
        {
            Province = province;
            City = city;
            Town = town;
            Village = village;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Province;
            yield return City;
            yield return Town;
            yield return Village;
        }
    }
}