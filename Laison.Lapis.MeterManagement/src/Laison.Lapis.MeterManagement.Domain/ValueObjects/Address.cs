using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace Laison.Lapis.MeterManagement.Domain.ValueObjects
{
    /// <summary>
    /// Value Object
    /// </summary>
    public class Address : ValueObject
    {
        public Guid CityId { get; private set; }

        public string Street { get; private set; }

        public int Number { get; private set; }

        private Address()
        {
        }

        public Address(Guid cityId, string street, int number)
        {
            CityId = cityId;
            Street = street;
            Number = number;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street;
            yield return CityId;
            yield return Number;
        }
    }
}