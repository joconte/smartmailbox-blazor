using System;
using Newtonsoft.Json;
using SmartMailBoxLib.Models;
using SmartMailBoxLib.REST;
namespace SmartMailBoxLib.Services
{
    public class UtilisateurServiceApi : IUtilisateurService
    {
        private RestService _restService; //TODO !

        public UtilisateurServiceApi()
        {
        }

        public GenericObjectWithErrorModel<Utilisateur> GetUtilisateurConnectedWithErrorModel()
        {
            return _restService.GetResponse<GenericObjectWithErrorModel<Utilisateur>>(Constants.UtilisateurConnected);
        }

        public GenericObjectWithErrorModel<Utilisateur> PutInformationsPersonnelles(Utilisateur utilisateurUpdated)
        {
            return _restService.PutResponse<Utilisateur>(Constants.UpdateUser, JsonConvert.SerializeObject(utilisateurUpdated));
        }
    }
}
