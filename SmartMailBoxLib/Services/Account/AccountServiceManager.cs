using System;
using System.Net.Http;
using SmartMailBoxLib.Models;

namespace SmartMailBoxLib.Services
{
    public class AccountServiceManager
    {
        private readonly AccountServiceApi _accountServiceApi;

        public AccountServiceManager(AccountServiceApi accountServiceApi)
        {
            _accountServiceApi = accountServiceApi;
        }

        public IAccountService GetAccountService()
        {
            IAccountService accountService;
            if (Constants.IsMocked)
                accountService = new AccountServiceMocked();
            else
                accountService = _accountServiceApi;

            return accountService;
        }
    }
}
