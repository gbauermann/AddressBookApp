using EFCoreBLL;
using System.Threading.Tasks;

namespace AddressBook.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AddressBookContext context;
        private IPeopleRepository peopleRepository;

        public UnitOfWork(AddressBookContext context)
        {
            this.context = context;
        }

        public IPeopleRepository People => peopleRepository ??= new PeopleRepository(context);

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
