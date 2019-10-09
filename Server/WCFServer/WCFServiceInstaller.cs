using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace KMA.APZRP2019.WalletSimulator.Server.WCFServer
{
    [RunInstaller(true)]
    public partial class WCFServiceInstaller : System.Configuration.Install.Installer
    {
        public WCFServiceInstaller()
        {
            InitializeComponent();
            _serviceProcessInstaller = new ServiceProcessInstaller();
            _serviceInstaller = new ServiceInstaller();
            _serviceProcessInstaller.Account = ServiceAccount.LocalSystem;
            _serviceProcessInstaller.Password = null;
            _serviceProcessInstaller.Username = null;
            _serviceInstaller.ServiceName = WalletWCFService.CurrentServiceName;
            _serviceInstaller.DisplayName = WalletWCFService.CurrentServiceDisplayName;
            _serviceInstaller.Description = WalletWCFService.CurrentServiceDescription;
            _serviceInstaller.StartType = ServiceStartMode.Automatic;
            Installers.AddRange(new Installer[]
            {
                _serviceProcessInstaller,
                _serviceInstaller
            });
        }
        private ServiceProcessInstaller _serviceProcessInstaller;
        private ServiceInstaller _serviceInstaller;
    }
}
