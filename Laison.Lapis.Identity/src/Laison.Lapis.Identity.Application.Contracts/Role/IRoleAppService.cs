using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Identity.Application.Contracts
{
    public interface IRoleAppService : IApplicationService
    {
        Task<ListResultDto<RoleDto>> GetAllListAsync();
    }
}