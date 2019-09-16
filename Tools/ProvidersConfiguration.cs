using System.Configuration;

namespace KMA.APZRP2019.Tools
{
    internal class ProvidersConfiguration:ConfigurationSection
    {
        [ConfigurationProperty("DBProvider")]
        public ProviderSettings DBProvider
        {
            get
            {
                return (ProviderSettings)base["DBProvider"];
            }
        }

    }
}
