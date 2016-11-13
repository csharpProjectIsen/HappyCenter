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
using System.Windows.Shapes;

namespace HappyCenter.View
{
    /// <summary>
    /// Interaction logic for VoirDesinscription.xaml
    /// </summary>
    public partial class VoirDesinscription : Window
    {
        public VoirDesinscription()
        {
            InitializeComponent();
        }

        private void MenuItem_Accueil_Click(object sender, RoutedEventArgs e)
        {
            VoirAccueil accueil = new VoirAccueil();
            accueil.Show();
            this.Close();
        }

        private void MenuItem_Informations_Click(object sender, RoutedEventArgs e)
        {
            VoirInformations informations = new VoirInformations();
            informations.Show();
            this.Close();
        }

        private void MenuItem_Mon_Planning_Click(object sender, RoutedEventArgs e)
        {
            VoirPlannification monPlanning = new VoirPlannification();
            monPlanning.Show();
            this.Close();
        }

        private void MenuItem_Contact_Click(object sender, RoutedEventArgs e)
        {
            VoirContact contact = new VoirContact();
            contact.Show();
            this.Close();
        }

        private void MenuItem_Chat_Click(object sender, RoutedEventArgs e)
        {
            VoirChat chat = new VoirChat();
            chat.Show();
            this.Close();
        }

        private void btnDesinscriptionArts_Click(object sender, RoutedEventArgs e)
        {
            if (cboxDesinscriptionArts.Text =="")
            {
                MessageBox.Show("Veuillez sélectionner un jour !");
            }
            else
            {
                MessageBox.Show("Désinscription à l'Atelier Arts du " + cboxDesinscriptionArts.Text + " réussie !");
            }
        }

        private void btnDesinscriptionCuisine_Click(object sender, RoutedEventArgs e)
        {
            if (cboxDesinscriptionCuisine.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un jour !");
            }
            else
            {
                MessageBox.Show("Désinscription à l'Atelier Cuisine du " + cboxDesinscriptionCuisine.Text + " réussie !");
            }
        }

        private void btnDesinscriptionArtsEspagnole_Click(object sender, RoutedEventArgs e)
        {
            if (cboxDesinscriptionEspagnole.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un jour !");
            }
            else
            {
                MessageBox.Show("Désinscription à l'Atelier Espagnole du " + cboxDesinscriptionEspagnole.Text + " réussie !");
            }
        }

        private void btnDesinscriptionFootball_Click(object sender, RoutedEventArgs e)
        {
            if (cboxDesinscriptionFootball.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un jour !");
            }
            else
            {
                MessageBox.Show("Désinscription à l'Atelier Football du " + cboxDesinscriptionFootball.Text + " réussie !");
            }
        }

        private void btnDesinscriptionJeuxDeSociete_Click(object sender, RoutedEventArgs e)
        {
            if (cboxDesinscriptionJeuxDeSociete.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un jour !");
            }
            else
            {
                MessageBox.Show("Désinscription à l'Atelier Jeux de Société du " + cboxDesinscriptionJeuxDeSociete.Text + " réussie !");
            }
        }

        private void btnDesinscriptionFitness_Click(object sender, RoutedEventArgs e)
        {
            if (cboxDesinscriptionFitness.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un jour !");
            }
            else
            {
                MessageBox.Show("Désinscription à l'Atelier Fitness du " + cboxDesinscriptionFitness.Text + " réussie !");
            }
        }
    }
}
