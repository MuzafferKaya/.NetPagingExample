using PagingExample.Entities;

namespace PagingExample.Abstract
{
    public interface IOwnerService
    {
        Task<PagedList<Owner>> GetOwners(OwnerParameters ownerParameters);
    }
}
