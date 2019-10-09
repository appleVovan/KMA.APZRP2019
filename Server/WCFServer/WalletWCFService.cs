using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KMA.APZRP2019.WalletSimulator.Server.Implementation;

namespace KMA.APZRP2019.WalletSimulator.Server.WCFServer
{
    partial class WalletWCFService : ServiceBase
    {
        internal const string CurrentServiceName = "WalletSimulatorService";
        internal const string CurrentServiceDisplayName = "Wallet Simulator Service";
        internal const string CurrentServiceSource = "WalletSimulatorServiceSource";
        internal const string CurrentServiceLogName = "WalletSimulatorServiceLogName";
        internal const string CurrentServiceDescription = "Wallet Simulator for learning purposes.";
        private ServiceHost _serviceHost = null;

        public WalletWCFService()
        {
            InitializeComponent();
            ServiceName = CurrentServiceName;
            AppDomain.CurrentDomain.UnhandledException += UnhandledException;
        }

        private void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //TODO implement Logging
        }

        protected override void OnStart(string[] args)
        {
#if DEBUG
            RequestAdditionalTime(120 * 1000);
            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(1000);
            //}
#endif
            _serviceHost?.Close();
            try
            {
                _serviceHost = new ServiceHost(typeof(WalletSimulatorImpl));
                _serviceHost.Open();
            }
            catch (Exception ex)
            {
                //TODO implement Logging
                throw;
            }
        }

        protected override void OnStop()
        {
            RequestAdditionalTime(120 * 1000);
            try
            {
                _serviceHost.Close();
            }
            catch (Exception ex)
            {
                //TODO add Logging
            }
        }
    }
}
