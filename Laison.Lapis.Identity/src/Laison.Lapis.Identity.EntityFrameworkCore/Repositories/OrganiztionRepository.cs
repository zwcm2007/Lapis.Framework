using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
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

        /// <summary>
        /// 获取所有下级组织
        /// </summary>
        /// <param name="code"></param>
        /// <param name="parentId"></param>
        /// <param name="includeDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<List<Organization>> GetAllChildrenWithParentCodeAsync(string code, Guid? parentId, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
                .IncludeDetails(includeDetails)
                .Where(ou => ou.Code.StartsWith(code) && ou.Id != parentId.Value)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        /// <summary>
        /// 根据显示名称获取组织
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="includeDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 获取下级组织信息
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="includeDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<List<Organization>> GetChildrenAsync(Guid? parentId, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
               .IncludeDetails(includeDetails)
               .Where(x => x.ParentId == parentId)
               .ToListAsync(GetCancellationToken(cancellationToken));
        }

        /// <summary>
        /// 分页获取组织信息
        /// </summary>
        /// <param name="sorting"></param>
        /// <param name="maxResultCount"></param>
        /// <param name="skipCount"></param>
        /// <param name="includeDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<List<Organization>> GetListAsync(string sorting = null, int maxResultCount = int.MaxValue, int skipCount = 0, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
               .IncludeDetails(includeDetails)
               .OrderBy("sorting", nameof(Organization.DisplayName))
               .PageBy(skipCount, maxResultCount)
               .ToListAsync(GetCancellationToken(cancellationToken));
        }
    }
}