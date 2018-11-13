using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModel
{
    public class SimulatorViewModel: ISimulatorViewModel
    {

        public ObservableCollection<string> Lines { get; private set; }

        public SimulatorViewModel()
        {
            Lines = new ObservableCollection<string>
         {
            "test 1",
            "test 2"
            };
      
        }










    }
}
