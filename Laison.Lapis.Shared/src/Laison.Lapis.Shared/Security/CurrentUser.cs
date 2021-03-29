using System;
using System.Linq;
using System.Security.Claims;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Security.Claims;

namespace Laison.Lapis.Shared
{
    public class CurrentUser : ICurrentUser, ITransientDependency
    {
        private static readonly Claim[] EmptyClaimsArray = new Claim[0];

        public virtual bool IsAuthenticated => Id.HasValue;

        public virtual int? Id
        {
            get
            {
                var userIdOrNull = FindClaim(AbpClaimTypes.UserId);

                if (userIdOrNull == null || userIdOrNull.Value.IsNullOrWhiteSpace())
                {
                    return null;
                }

                if (int.TryParse(userIdOrNull.Value, out int result))
                {
                    return result;
                }
                return null;
            }
        }

        public virtual string UserName => this.FindClaimValue(AbpClaimTypes.UserName);

        public virtual string PhoneNumber => this.FindClaimValue(AbpClaimTypes.PhoneNumber);

        public virtual string AccountId => this.FindClaimValue("AccountId");

        public virtual string Email => this.FindClaimValue(AbpClaimTypes.Email);

        //public virtual Guid? TenantId => _principalAccessor.Principal?.FindTenantId();

        public virtual string[] Roles => FindClaims(AbpClaimTypes.Role).Select(c => c.Value).ToArray();

        private readonly ICurrentPrincipalAccessor _principalAccessor;

        public CurrentUser(ICurrentPrincipalAccessor principalAccessor)
        {
            _principalAccessor = principalAccessor;
        }

        public virtual Claim FindClaim(string claimType)
        {
            return _principalAccessor.Principal?.Claims.FirstOrDefault(c => c.Type == claimType);
        }

        public virtual Claim[] FindClaims(string claimType)
        {
            return _principalAccessor.Principal?.Claims.Where(c => c.Type == claimType).ToArray() ?? EmptyClaimsArray;
        }

        public virtual Claim[] GetAllClaims()
        {
            return _principalAccessor.Principal?.Claims.ToArray() ?? EmptyClaimsArray;
        }

        public virtual bool IsInRole(string roleName)
        {
            return FindClaims(AbpClaimTypes.Role).Any(c => c.Value == roleName);
        }
    }
}