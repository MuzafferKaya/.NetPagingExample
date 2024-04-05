using Microsoft.EntityFrameworkCore;
using PagingExample.Abstract;
using PagingExample.Context;
using PagingExample.Entities;

namespace PagingExample.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly AppDbContext _context;

        public OwnerService(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<PagedList<Owner>> GetOwners(OwnerParameters ownerParameters)
        {
            return await PagedList<Owner>.toPagedList(_context.Owners, ownerParameters.PageNumber, ownerParameters.pageSize);
        }
    }
}
