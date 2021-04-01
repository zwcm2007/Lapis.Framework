using Laison.Lapis.Identity.Domain.ValueObjects;

namespace Laison.Lapis.Identity.Application.Contracts
{
    /// <summary>
    /// create order dto
    /// </summary>
    public class CreateUserInput
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Sex? Sex { get; set; }
    }
}