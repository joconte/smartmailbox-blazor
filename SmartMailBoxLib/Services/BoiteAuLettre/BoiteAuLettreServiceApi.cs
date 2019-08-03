using System;
using Newtonsoft.Json;
using SmartMailBoxLib.Models;
using SmartMailBoxLib.REST;

namespace SmartMailBoxLib.Services
{
    public class BoiteAuLettreServiceApi : IBoiteAuLettreService
    {
        private RestService _restService; //TODO !

        public BoiteAuLettreServiceApi()
        {
        }

        public GenericObjectWithErrorModel<BoiteAuLettre> PostCreateBoiteAuLettre(BoiteAuLettre boiteAuLettre)
        {
            return _restService.PostReponse<BoiteAuLettre>(Constants.CreateBAL, JsonConvert.SerializeObject(boiteAuLettre));
        }

        public GenericObjectWithErrorModel<Utilisateur> PutAjoutBoiteToUtilisateur(BoiteAuLettre boiteAuLettre)
        {
            return _restService.PostReponse<Utilisateur>(Constants.AddBalToCurrentUser, JsonConvert.SerializeObject(boiteAuLettre));
        }
    }
}
