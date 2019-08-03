using System;
using SmartMailBoxLib.Models;
using SmartMailBoxLib.REST;

namespace SmartMailBoxLib.Services
{
    public class CourrierServiceApi : ICourrierService
    {
        private RestService _restService; //TODO !
        public CourrierServiceApi()
        {
        }

        public GenericObjectWithErrorModel<Models.Courrier> PutCourrierVu(int pId)
        {
            return _restService.PutResponse<Models.Courrier>(String.Format(Constants.UpdateCourrierBybyId, pId), null);
        }
    }
}
