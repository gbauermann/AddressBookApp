using System;
using System.Threading.Tasks;

namespace AddressBook.Data
{
    public interface IUnitOfWork: IDisposable
    {
        IPeopleRepository People { get; }

        Task<int> CommitAsync();
    }
}