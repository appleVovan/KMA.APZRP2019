using System;
using System.Configuration;
using KMA.APZRP2019.WalletSimulator.Providers;

namespace KMA.APZRP2019.WalletSimulator.Tools
{
    public static class ProviderFactory
    {
        private static ProvidersConfiguration _configuration;
        static ProviderFactory()
        {
            Initialize();
        }
        public static IDBProvider CreateNewDBProvider()
        {
            return (IDBProvider)Activator.CreateInstance(_configuration.DBProvider.Name, _configuration.DBProvider.Type).Unwrap();
        }

        private static void Initialize()
        {
            _configuration =  (ProvidersConfiguration)ConfigurationManager.GetSection("providers");
            if (_configuration == null)
                throw new ConfigurationErrorsException("Data provider section is not set.");
        }
    }
}
