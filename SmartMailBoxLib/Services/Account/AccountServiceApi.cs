using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Ninject;
using SmartMailBoxLib.Models;
using SmartMailBoxLib.REST;

namespace SmartMailBoxLib.Services
{
    public class AccountServiceApi : IAccountService
    {
        
        public AccountServiceApi()
        {
        }

        //Login api avec token
        public async Task<string> Login(Utilisateur utilisateur)
        {
            string response = RestService.Instance.PostReponseLogin(Constants.LoginUrl, utilisateur);
            RestService.Instance.AddBearerTokenToHeader(response);
            return response;
        }

        public GenericObjectWithErrorModel<string> PostForgotPassword(string pUsername)
        {
            return RestService.Instance.PostReponse<string>(Constants.ForgotPassword, pUsername);
        }

        public GenericObjectWithErrorModel<Utilisateur> PostCreateAccount(Utilisateur _utilisateur)
        {
            return RestService.Instance.PostReponse<Utilisateur>(Constants.RegisterUtilisateur, JsonConvert.SerializeObject(_utilisateur));
        }

        public void Logout()
        {
            RestService.Instance.Logout();
        }

    }
}
