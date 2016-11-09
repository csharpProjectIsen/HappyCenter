using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HappyCenter
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HappyCenter.View.VoirAccueil va = new View.VoirAccueil();
            HappyCenter.View.VoirInformations vi = new View.VoirInformations();
            HappyCenter.View.VoirActivite vac = new View.VoirActivite();
            va.Show();
            vi.Show();
            //vac.Show();
        }
    }
}
