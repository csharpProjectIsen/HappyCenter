using System;
using System.Collections.Generic;
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
            HappyCenter.View.VoirContact vc = new View.VoirContact();
            HappyCenter.View.VoirPlannification vp = new View.VoirPlannification();
            HappyCenter.View.VoirDesinscription vd = new View.VoirDesinscription();
            HappyCenter.View.VoirInscription vi = new View.VoirInscription();
            InitializeComponent();
            vc.Show();
            vp.Show();
            vd.Show();
            vi.Show();

        }
    }
}
