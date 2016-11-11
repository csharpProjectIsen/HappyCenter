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
    /// Logique d'interaction pour VoirAccueil.xaml
    /// </summary>
    public partial class VoirAccueil : Window
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

        public VoirAccueil()
        {
            InitializeComponent();
            //code tableau planning
            var list = new ObservableCollection<DataObject>();
            list.Add(new DataObject() { A = "", B = "MARDI", C = "MERCREDI", D ="JEUDI", E = "VENDREDI", F = "SAMEDI"  });
            list.Add(new DataObject() { A = "\n"+"8h - 10 h", B = "Cuisine\n" +"Jean H", C = " ", D = " ", E = " ", F = "Jeu de\n"+"société\n"+"Hélène F" });
            list.Add(new DataObject() { A = "\n"+"10h - 12 h", B = " ", C = "Arts\n\n"+"Claude M", D = "Espagnol\n\n"+"Mario B", E = "Basket\n\n"+"Pierre L", F = "Fitness\n\n"+"Laura A" });
            list.Add(new DataObject() { A = "\n" + "14h - 16 h", B = "Jeu de\n"+"société\n"+"Hélène F", C = "Fitness\n"+"Laura A", D = " ", E = "Arts\n"+"Claude M", F = " " });
            list.Add(new DataObject() { A = "\n" + "16h - 18 h", B = " ", C = " ", D = "Foot\n\n"+"Mathieu D", E = " ", F = " " });
            this.planning.ItemsSource = list;

            //code images activités
            

        }

        private void btn_cuisine_Click(object sender, RoutedEventArgs e)
        {
            VoirActiviteCuisine cuisine = new VoirActiviteCuisine();
            cuisine.etat.Content = cuisine.CalculEtat();
            cuisine.Show();
            this.Close();
        }

        private void btn_arts_Click(object sender, RoutedEventArgs e)
        {
            VoirActiviteArts arts = new VoirActiviteArts();
            arts.etat.Content = arts.CalculEtat();
            arts.Show();
            this.Close();
        }

        private void btn_foot_Click(object sender, RoutedEventArgs e)
        {
            VoirActiviteFoot foot = new VoirActiviteFoot();
            foot.etat.Content = foot.CalculEtat();
            foot.Show();
            this.Close();
        }

        private void btn_jeuxsociete_Click(object sender, RoutedEventArgs e)
        {
            VoirActiviteJeuxSociete jeuxSo = new VoirActiviteJeuxSociete();
            jeuxSo.etat.Content = jeuxSo.CalculEtat();
            jeuxSo.Show();
            this.Close();
        }

        private void btn_fitness_Click(object sender, RoutedEventArgs e)
        {
            VoirActiviteFitness fitness = new VoirActiviteFitness();
            fitness.etat.Content = fitness.CalculEtat();
            fitness.Show();
            this.Close();
        }

        private void btn_espagnol_Click(object sender, RoutedEventArgs e)
        {
            VoirActiviteEspagnol espagnol = new VoirActiviteEspagnol();
            espagnol.etat.Content = espagnol.CalculEtat();
            espagnol.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

  
    }
}
