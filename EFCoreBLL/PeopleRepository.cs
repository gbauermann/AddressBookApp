using EFCoreBLL;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.Data
{
    public class PeopleRepository : Repository<Person>, IPeopleRepository
    {
        public PeopleRepository(AddressBookContext context) : base(context)
        { }

        //https://medium.com/swlh/building-a-nice-multi-layer-net-core-3-api-c68a9ef16368

        public override ValueTask<Person> GetByIdAsync(int id)
        {
            return base.GetByIdAsync(id);
        }

        public override Task<List<Person>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Person Add(Person person)
        {
            return base.Add(person);
        }
    }
}
