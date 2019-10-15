using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using KMA.APZRP2019.WalletSimulator.DBModels;
using KMA.APZRP2019.WalletSimulator.Server.Interface;

namespace Tester
{
    public class WalletSimulatorRestApiClient : IDisposable, IWalletSimulator
    { 
        HttpClient _client = new HttpClient();
        Uri _serviceBaseUri;

        public WalletSimulatorRestApiClient()
        {
            _serviceBaseUri = new Uri(@"https://localhost:44354/api/values");
        }


        public IEnumerable<User> GetAllUsers()
        {

            var response = _client.GetAsync(_serviceBaseUri.AddSegment(nameof(GetAllUsers))).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<User>>().Result;

            }
            else if (response.StatusCode != HttpStatusCode.NotFound)
            {
                throw new InvalidOperationException("Get failed with " + response.StatusCode.ToString());
            }

            return null;
        }

        public void AddUser(User user)
        {
            var response = _client.PostAsJsonAsync(_serviceBaseUri.AddSegment(nameof(AddUser)), user).Result;

            if (!response.IsSuccessStatusCode)
                throw new InvalidOperationException("Create failed with " + response.StatusCode.ToString());
        }



        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                _client = null;
                _serviceBaseUri = null;
            }
        }

        public void Dispose()
        {
            this.Dispose(false);
            GC.SuppressFinalize(this);
        }

        ~WalletSimulatorRestApiClient()
        {
            this.Dispose(false);
        }

        
    }

    static class UriExtensions
    {
        public static Uri AddSegment(this Uri originalUri, string segment)
        {
            UriBuilder ub = new UriBuilder(originalUri);
            ub.Path = ub.Path + ((ub.Path.EndsWith("/")) ? "" : "/") + segment;

            return ub.Uri;
        }
    }
}
