using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    /// <summary>
    /// 组织仓储
    /// </summary>
    public class OrganizationRepository : EfCoreRepository<IIdentityDbContext, Organization, Guid>, IOrganizationRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbContextProvider"></param>
        public OrganizationRepository(IDbContextProvider<IIdentityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public Task<List<Organization>> GetAllChildrenWithParentCodeAsync(string code, Guid? parentId, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<Organization> GetAsync(string displayName, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
              .IncludeDetails(includeDetails)
              .OrderBy(x => x.Id)
              .FirstOrDefaultAsync(
                  o => o.DisplayName == displayName,
                  GetCancellationToken(cancellationToken)
              );
        }

        public Task<List<Organization>> GetChildrenAsync(Guid? parentId, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Organization>> GetListAsync(string sorting = null, int maxResultCount = int.MaxValue, int skipCount = 0, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}