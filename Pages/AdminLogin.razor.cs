using AdminDashboard.Authentication;
using AdminDashboard.DAL;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace AdminDashboard.Pages
{
    public partial class AdminLogin
    {
        [Inject]
        AuthenticationStateProvider authenticationStateProvider { get; set; }
        [Inject]
        protected ILocalStorageService storageService { get; set; }
        private async Task Login()
        {
            try
            {
                 UserModel obj = new UserModel();

                if (loginModel.Email == "Admin" && loginModel.Password == "Admin")
                {
                    obj.Email = "Admin";
                    obj.UserId = 1;
                    await storageService.SetItemAsync("LoginObj", obj);
                    ((CustomAuthenticationStateProvider)authenticationStateProvider).MarkUserisAuthenticated(obj);
                    navigationManager.NavigateTo("/Dashboard");

                }
                else
                {
                    fail = true;
                    Msg = "Please Enter correct username/password";

                }






            }
            catch (Exception ex)
            {

            }
        }
    }
}
