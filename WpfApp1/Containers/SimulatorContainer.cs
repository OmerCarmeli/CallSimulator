using CN.Common.Contracts;
using CN.Common.Contracts.IViewModels;
using CN.Common.LoggersAndPoppers;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Signalr;
using WpfApp1.ViewModel;

namespace WpfApp1.Containers
{
    public static class SimulatorContainer
    {

            public static Container container { get; set; }
            static SimulatorContainer()
            {
                if (container == null)
                {
                    container = new Container();
                    container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

                    //ViewModels
                    container.Register<ILoginViewModel, LoginViewModel>();
                    container.Register<ISimulatorViewModel, SimulatorViewModel>();

                    //Services
                    container.Register<ILogger, MessageBoxPopper>(Lifestyle.Singleton);
                    container.Register<ISignalrClient, SignalrClient>(Lifestyle.Singleton);

                    container.Verify();
                }
            }
        }
}
