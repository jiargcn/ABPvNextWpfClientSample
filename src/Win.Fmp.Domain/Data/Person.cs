using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Win.Fmp.Data
{
    public class Person:AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int Age  { get; set; }
    }
}