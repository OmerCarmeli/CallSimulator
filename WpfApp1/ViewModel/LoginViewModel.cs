using CN.Common.Contracts;
using CN.Common.Contracts.IViewModels;
using CN.Common.Infrastructures;
using CN.Common.Models;
using CN.Common.Models.TempModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Windows;

namespace WpfApp1.ViewModel
{
    class LoginViewModel : ILoginViewModel
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand loginCommand { get; set; }
        ILogger logger { get; set; }
        ISignalrClient signalrClient { get; set; }


        public LoginViewModel()
        {

            loginCommand = new ActionCommand<object>(TryLogin);

        }

        /*
        public LoginViewModel(ILogger logger, ISignalrClient signalrClient)
        {
          //  this.logger = logger;
        //    this.signalrClient = signalrClient;
            loginCommand = new ActionCommand<object>(TryLogin);
        }
        */


        private void TryLogin(object parameter)
        {
            Console.WriteLine("asdasdas");
            SimulatorView simulator = new SimulatorView();
            simulator.Show();
            //Sends the info to the server and tries a login
            //PasswordBox psbox = (PasswordBox)parameter;
            //Password = psbox.Password;
            //if (ValidateFields())
            //{
            //    UserLogin userLogin = new UserLogin(Username, Password);
            //    User loggedIn = signalrClient.TrySendLogin(userLogin).Result;
            //    //  logger.Print(loggedIn.Username);

            //}
        }

            public bool ValidateFields()
            {
                //validates the fields
                List<string> validationInfo = new List<string>();
                bool valid = true;
                if (string.IsNullOrWhiteSpace(Username))
                {
                    validationInfo.Add("Please insert a username");
                    valid = false;
                }
                if (string.IsNullOrWhiteSpace(Password))
                {
                    validationInfo.Add("Please insert a password");
                    valid = false;
                }
               // logger.PrintList(validationInfo);
                return valid;
            }
     }


 }

