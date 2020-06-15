﻿using AutoMapper;

namespace Eyez.Backend
{
    public class BackendApplicationAutoMapperProfile : Profile
    {
        public BackendApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
