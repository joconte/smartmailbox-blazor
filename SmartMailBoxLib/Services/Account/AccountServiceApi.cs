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
        private RestService _restService;
        
        public AccountServiceApi(RestService restService)
        {
            _restService = restService;
        }

        //Login api avec token
        public async Task<string> Login(Utilisateur utilisateur)
        {
            Console.WriteLine(Constants.LoginUrl);
            string response = await _restService.PostReponseLogin(Constants.LoginUrl, utilisateur);
            Console.WriteLine(response);
            _restService.AddBearerTokenToHeader(response);
            return response;
        }

        public GenericObjectWithErrorModel<string> PostForgotPassword(string pUsername)
        {
            return _restService.PostReponse<string>(Constants.ForgotPassword, pUsername);
        }

        public GenericObjectWithErrorModel<Utilisateur> PostCreateAccount(Utilisateur _utilisateur)
        {
            return _restService.PostReponse<Utilisateur>(Constants.RegisterUtilisateur, JsonConvert.SerializeObject(_utilisateur));
        }

        public void Logout()
        {
            _restService.Logout();
        }

    }
}
