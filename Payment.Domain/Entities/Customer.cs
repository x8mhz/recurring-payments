using System.Collections.Generic;
using System.Linq;
using Payment.Domain.Common.Entity;
using Payment.Domain.ValueObjects;
using Document = Payment.Domain.ValueObjects.Document;
using Name = Payment.Domain.ValueObjects.Name;

namespace Payment.Domain.Entities
{
    public class Customer : Entity
    {
        private readonly IEnumerable<Subscription> _subscriptions;

        public Customer(Name name, Document document, Email email, Address address)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IEnumerable<Subscription> Subscriptions => _subscriptions.ToArray();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}