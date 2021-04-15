using Laison.Lapis.PermissionManagement.Domain;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    /// <summary>
    /// PermissionGrantRepository
    /// </summary>
    public class PermissionGrantRepository : EfCoreRepository<IPermissionManagementDbContext, PermissionGrant, Guid>, IPermissionGrantRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbContextProvider"></param>
        public PermissionGrantRepository(IDbContextProvider<IPermissionManagementDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public Task<PermissionGrant> FindAsync(string name, string providerName, string providerKey, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<PermissionGrant>> GetListAsync(string providerName, string providerKey, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<PermissionGrant>> GetListAsync(string[] names, string providerName, string providerKey, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}