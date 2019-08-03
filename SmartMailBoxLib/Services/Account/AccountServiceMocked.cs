using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using SmartMailBoxLib.Models;
using SmartMailBoxLib.REST;

namespace SmartMailBoxLib.Services
{
    public class AccountServiceMocked : IAccountService
    {
        private RestService _restService; //TODO !
        public AccountServiceMocked()
        {
        }

        public async Task<string> Login(Utilisateur utilisateur)
        {
            string response = "TokenMocked";
            _restService.AddBearerTokenToHeader(response);
            return response;
        }

        public GenericObjectWithErrorModel<string> PostForgotPassword(string pUsername)
        {
            GenericObjectWithErrorModel<string> genericObjectWithErrorModel = new GenericObjectWithErrorModel<string>();
            genericObjectWithErrorModel.t = "ForgotPasswordMocked";
            return genericObjectWithErrorModel;
        }

        public GenericObjectWithErrorModel<Utilisateur> PostCreateAccount(Utilisateur _utilisateur)
        {
            GenericObjectWithErrorModel<Utilisateur> genericObjectWithErrorModel = new GenericObjectWithErrorModel<Utilisateur>();
            Utilisateur utilisateur = new Utilisateur();
            genericObjectWithErrorModel.t = utilisateur;
            return genericObjectWithErrorModel;
        }

        public void Logout()
        {
            _restService.Logout();
        }
    }
}
