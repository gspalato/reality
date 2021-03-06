using Reality.Common.Entities;
using Reality.Common.Payloads;
using Reality.Services.Identity.Services;

namespace Reality.Services.Identity.Mutations
{
    public class Mutation
    {
        public async Task<User?> CreateUserAsync(string username, string password,
            [Service] IUserService userService) => await userService.CreateUserAsync(username, password);

        public async Task<AuthenticationPayload> AuthenticateAsync(string username, string password,
            [Service] IAuthenticationService authService)
        {
            return await authService.AuthenticateAsync(username, password);
        }
    }
}
