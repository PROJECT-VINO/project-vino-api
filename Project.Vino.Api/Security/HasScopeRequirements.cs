using Microsoft.AspNetCore.Authorization;
using Microsoft.OpenApi.Writers;

namespace Project.Vino.Api.Security
{
    public class HasScopeRequirements : IAuthorizationRequirement
    {
        public string Issuer { get; }
        public string Scope { get; }

        public HasScopeRequirements(string scope, string issuer)
        {
            Scope = scope ?? throw new ArgumentNullException(nameof(scope));
            issuer = issuer ?? throw new ArgumentNullException(nameof(issuer));
        }
    }
}