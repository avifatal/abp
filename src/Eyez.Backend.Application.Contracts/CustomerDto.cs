using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Eyez.Backend
{
    public class CustomerDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
