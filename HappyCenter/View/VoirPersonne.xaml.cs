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
    /// Logique d'interaction pour VoirPersonne.xaml
    /// </summary>
    public partial class VoirPersonne : Window
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
        public VoirPersonne()
        {
           // HappyCenter.View.VoirPersonne vp = new View.VoirPersonne();
            InitializeComponent();
            // vp.Show();
            var list = new ObservableCollection<DataObject>();
            list.Add(new DataObject() { A = "", B = "MARDI", C = "MERCREDI", D = "JEUDI", E = "VENDREDI", F = "SAMEDI" });
            list.Add(new DataObject() { A = "8h - 10 h", B = " ", C = " ", D = " ", E = " ", F = " " });
            list.Add(new DataObject() { A = "10h - 12 h", B = " ", C = " ", D = " ", E = " ", F = " " });
            list.Add(new DataObject() { A = "14h - 16 h", B = " ", C = " ", D = " ", E = " ", F = " " });
            list.Add(new DataObject() { A = "16h - 18 h", B = " ", C = " ", D = " ", E = " ", F = " " });
            this.planning.ItemsSource = list;


        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void planning_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
