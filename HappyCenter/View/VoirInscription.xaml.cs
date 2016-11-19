﻿using System;
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
    /// Interaction logic for VoirInscription.xaml
    /// </summary>
    public partial class VoirInscription : Window
    {
        public VoirInscription()
        {
            InitializeComponent();
        }

        //Onglet Accueil de la barre Menu
        private void MenuItem_Accueil_Click(object sender, RoutedEventArgs e)
        {
            VoirAccueil accueil = new VoirAccueil();
            accueil.Show();
            this.Close();
        }

        //Onglet Informations de la barre Menu
        private void MenuItem_Informations_Click(object sender, RoutedEventArgs e)
        {
            VoirInformations informations = new VoirInformations();
            informations.Show();
            this.Close();
        }

        //Onglet Mon Planning de la barre Menu
        private void MenuItem_Mon_Planning_Click(object sender, RoutedEventArgs e)
        {
            VoirPlannification monPlanning = new VoirPlannification();
            monPlanning.Show();
            this.Close();
        }

        //Onglet Contact de la barre Menu
        private void MenuItem_Contact_Click(object sender, RoutedEventArgs e)
        {
            VoirContact contact = new VoirContact();
            contact.Show();
            this.Close();
        }

        //Onglet Chat de la barre Menu
        private void MenuItem_Chat_Click(object sender, RoutedEventArgs e)
        {
            VoirChat chat = new VoirChat();
            chat.Show();
            this.Close();
        }

        //Bouton Valider
        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if (tboxName.Text == "" || tboxPrenom.Text == "" || tboxAge.Text == "" || cboxNomActivite.Text == "" || cboxJourInscription.Text == "" || cboxHoraires.Text == "")
            {
                             
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
            else
            {
                MessageBox.Show("Inscription enregistrée !");
            }
        }

        //Bouton Modifier
        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {

            if (tboxName.Text == "" || tboxPrenom.Text == "" || tboxAge.Text == "" || cboxNomActivite.Text=="" || cboxJourInscription.Text=="" || cboxHoraires.Text=="" )
            {

                MessageBox.Show("Veuillez remplir tous les champs !");
            }
            else
            {
                MessageBox.Show("Modification enregistrée !");
            }
        }
    }
}
