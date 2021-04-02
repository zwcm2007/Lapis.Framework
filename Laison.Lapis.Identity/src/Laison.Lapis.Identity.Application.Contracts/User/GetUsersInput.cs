using Volo.Abp.Application.Dtos;

namespace Laison.Lapis.Identity.Application.Contracts
{
    public class GetUsersInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
