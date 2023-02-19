using AdminDashboard.DAL;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace AdminDashboard.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ILocalStorageService _LocalStorage;
        /// <summary>
        /// //private ISessionStorageService _SessionStorageService;
        /// </summary>
        /// <param name="SessionStorageService"></param>
        public CustomAuthenticationStateProvider(ILocalStorageService SessionStorageService)
        {
            _LocalStorage = SessionStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {


           UserModel obj = await _LocalStorage.GetItemAsync<UserModel>("LoginObj");
            ClaimsIdentity identity;
            var newClaims = new List<Claim>();




            if (obj != null)
            {


                //foreach (var item in obj)
                //{


                //    newClaims.Add(new Claim(ClaimTypes.Role, item..ToString()));
                //}

                newClaims.Add(new Claim(ClaimTypes.Name, "Admin"));


                identity = new ClaimsIdentity(newClaims, "apiauth_type");

            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserisAuthenticated(UserModel u)
        {

            var newClaims = new List<Claim>();

           

            newClaims.Add(new Claim(ClaimTypes.Role, u.UserId.ToString()));          
            newClaims.Add(new Claim(ClaimTypes.Name, "Admin"));
            var identity = new ClaimsIdentity(newClaims, "apiauth_type");
            _LocalStorage.SetItemAsync("LoginObj", u);
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));

        }
        public void MarkUserIsLogOut()
        {
            _LocalStorage.RemoveItemAsync("userId");

            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));

        }
    }
}
