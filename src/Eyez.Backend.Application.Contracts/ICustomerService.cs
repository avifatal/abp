using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Eyez.Backend
{
    public interface ICustomerService: ICrudAppService< //Defines CRUD methods
            CustomerDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
            CustomerDto, //Used to create a new book
            CustomerDto> //Used to update a book
    {

    }

}
