using AdminDashboard.DAL;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace AdminDashboard.Pages
{
    public partial class AddUser
    {
        [Inject]
        protected ILocalStorageService storageService { get; set; }
        UserModel userModel = new UserModel();
        LoginModel loginModel = new LoginModel();
        public bool success { get; set; } = false;
        public bool fail { get; set; } = false;
         public  string Msg = "";
        private async Task HandleValidSubmit()
        {
            try
            {

         

                var json = JsonConvert.SerializeObject(userModel, Formatting.None);
                var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var res = await _HttpClient.PostAsync($"api/User/RegisterUser", stringContent);

                var ret = await res.Content.ReadFromJsonAsync<string>();
                Msg = ret;


                if (ret.Contains("successfully") == true)
                {
                    success = true;
                    fail = false;
                }
                else
                {
                    fail = true;
                    success = false;
                }

                StateHasChanged();





            }
            catch (Exception ex)
            {

            }
        }
    }
}
