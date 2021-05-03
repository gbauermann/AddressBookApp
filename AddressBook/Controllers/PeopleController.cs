using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBook.Api.Resources;
using AddressBook.Service;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AddressBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonService personService;
        private readonly IMapper mapper;

        public PeopleController(IPersonService personService, IMapper mapper)
        {
            this.personService = personService;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonResource>> GetMusicById(int id)
        {
            var person = await personService.GetById(id);
            var personResource = mapper.Map<Person, PersonResource>(person);

            return Ok(personResource);
        }
    }
}
