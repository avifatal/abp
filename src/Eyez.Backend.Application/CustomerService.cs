using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Eyez.Backend
{


    public class CustomerService : CrudAppService<Customer, CustomerDto, Guid, PagedAndSortedResultRequestDto, CustomerDto, CustomerDto>, ICustomerService
    {
        public CustomerService(IRepository<Customer, Guid> repository) : base(repository)
        {

        }
    }
}
