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

namespace HappyCenter.View
{
    /// <summary>
    /// Interaction logic for VoirPlannification.xaml
    /// </summary>
    public partial class VoirPlannification : Window
    {
        public class DataObject
        {
            public string A { get; set; }
            public string B { get; set; }
            public string C { get; set; }
            public string D { get; set; }
            public string E { get; set; }
            public string F { get; set; }
        }


        public VoirPlannification()
        {
            InitializeComponent();
            var list = new ObservableCollection<DataObject>();
            list.Add(new DataObject() { A = "", B = "MARDI", C = "MERCREDI", D = "JEUDI", E = "VENDREDI", F = "SAMEDI" });
            list.Add(new DataObject() { A = "\n8h - 10 h", B = "\n\n", C = "\n\n", D = "\n\n", E = "\n\n", F = "\n\n" });
            list.Add(new DataObject() { A = "\n10h - 12 h", B = "\n\n", C = "\n\n", D = "\n\n", E = "\n\n", F = "\n\n" });
            list.Add(new DataObject() { A = "\n14h - 16 h", B = "\n\n", C = "\n\n", D = "\n\n", E = "\n\n", F = "\n\n" });
            list.Add(new DataObject() { A = "\n16h - 18 h", B = "\n\n", C = "\n\n", D = "\n\n", E = "\n\n", F = "\n\n" });
            this.plannings.ItemsSource = list;

        }

        private void MenuItem_Accueil_Click(object sender, RoutedEventArgs e)
        {
            VoirAccueil accueil = new VoirAccueil();
            accueil.Show();
            this.Close(); 
         }

        private void MenuItem_Chat_Click(object sender, RoutedEventArgs e)
        {
            VoirChat chat = new VoirChat();
            chat.Show();
            this.Close();
        }

        private void plannings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItem_Informations_Click(object sender, RoutedEventArgs e)
        {
            VoirInformations informations = new VoirInformations();
            informations.Show();
            this.Close();
        }

        private void MenuItem_Contact_Click(object sender, RoutedEventArgs e)
        {
            VoirContact contact = new VoirContact();
            contact.Show();
            this.Close();
        }
    }
}
