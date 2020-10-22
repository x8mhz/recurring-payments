using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Payment.Domain.Common.Entity;

namespace Payment.Domain.Entities
{
    public class Subscription : Entity
    {
        private readonly IEnumerable<Payment> _payments;

        public Subscription(DateTime? expireDate, IEnumerable<Payment> payments)
        {
            _payments = payments;
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IEnumerable<Payment> Payments => _payments.ToArray();
    }
}