using System.Collections.Generic;

namespace Laison.Lapis.PermissionManagement.Application.Contracts
{
    public class GetPermissionListResultDto
    {
        public string EntityDisplayName { get; set; }

        public List<PermissionGroupDto> Groups { get; set; }
    }
}