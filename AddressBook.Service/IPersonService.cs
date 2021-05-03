using Models;
using System.Threading.Tasks;

namespace AddressBook.Service
{
    public interface IPersonService
    {
        ValueTask<Person> GetById(int id);
    }
}