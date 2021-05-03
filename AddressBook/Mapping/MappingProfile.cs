using AddressBook.Api.Resources;
using AutoMapper;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Api.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonResource>();
            CreateMap<PersonResource, Person>();
        }
    }
}
