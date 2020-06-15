using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Eyez.Backend
{
    public class Customer : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public Customer()
        {
            
        }

        public Customer(Guid id, string name): base(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
