
using AddressBook.Data;
using Models;
using System.Threading.Tasks;

namespace AddressBook.Service
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public ValueTask<Person> GetById(int id)
        {
            return unitOfWork.People.GetByIdAsync(id);
        }
    }
}
