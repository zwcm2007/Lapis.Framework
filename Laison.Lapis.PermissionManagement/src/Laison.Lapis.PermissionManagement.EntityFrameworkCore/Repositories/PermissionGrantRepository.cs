using Laison.Lapis.PermissionManagement.Domain;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    /// <summary>
    /// PermissionGrantRepository
    /// </summary>
    public class PermissionGrantRepository : EfCoreRepository<IPermissionManagementDbContext, PermissionGrant, Guid>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbContextProvider"></param>
        public PermissionGrantRepository(IDbContextProvider<IPermissionManagementDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}