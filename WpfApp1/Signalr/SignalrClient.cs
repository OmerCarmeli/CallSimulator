using CN.Common.Contracts;
using CN.Common.Models;
using CN.Common.Models.TempModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using CN.Common.Configs;

namespace WpfApp1.Signalr
{
    class SignalrClient : ISignalrClient
    {

        public HubConnection connection { get; set; }
        public IHubProxy hub { get; set; }
        public ILogger logger { get; set; }

        public SignalrClient(ILogger logger)
        {
            this.logger = logger;
            connection = new HubConnection(MainConfigs.Url);
            hub = connection.CreateHubProxy(MainConfigs.HubName);

            hub.On("Welcome", (string welcome) =>
            {
                logger.Print(welcome);
            });
            try
            {
                //try connecting to the server
                connection.Start().Wait();
            }
            catch
            {
                //couldnt connect to the sever
                logger.Print("an error has occourd while trying to connect to the server");
            }
        }

        public void NotifyServerOnConnected()
        {
            hub.Invoke("ClientConnected");
        }


        public async Task<User> TrySendLogin(UserLogin userLogin)
        {
            //tries a login via the server
            User user = await hub.Invoke<User>("TryLogin", userLogin);
            return user;
        }
    }
}
