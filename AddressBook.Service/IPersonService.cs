using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.Service
{
    public interface IPersonService
    {
        ValueTask<Person> GetById(int id);
        Task<List<Person>> GetAllAsync();
    }
}