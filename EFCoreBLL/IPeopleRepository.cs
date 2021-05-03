using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.Data
{
    public interface IPeopleRepository
    {
        Person Add(Person person);
        Task<List<Person>> GetAllAsync();
        ValueTask<Person> GetByIdAsync(int id);
    }
}