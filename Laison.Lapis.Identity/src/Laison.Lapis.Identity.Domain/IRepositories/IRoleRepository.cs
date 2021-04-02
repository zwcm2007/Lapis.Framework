using Laison.Lapis.Identity.Domain.Entities;
using System;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Identity.Domain.IRepositories
{
    /// <summary>
    /// An interface for user repository
    /// </summary>
    public interface IRoleRepository : IBasicRepository<Role, Guid>
    {
    }
}