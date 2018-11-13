using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Containers;
using WpfApp1.ViewModel;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Interaction logic for SimulatorView.xaml
    /// </summary>
    public partial class SimulatorView : Window
    {
         ISimulatorViewModel SimulatorVM { get; set; }
        //IList<string> liens = new List<string>();
        public SimulatorView()
        {
            InitializeComponent();
            SimulatorVM = SimulatorContainer.container.GetInstance<ISimulatorViewModel>();
            DataContext = SimulatorVM;

        }

        private void LinesCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
