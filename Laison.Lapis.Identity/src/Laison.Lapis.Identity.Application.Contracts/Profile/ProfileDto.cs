namespace Laison.Lapis.Identity.Application.Contracts
{
    public class ProfileDto
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public bool HasPassword { get; set; }
    }
}