using HappyCenter.Properties;
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
using System.Windows.Shapes;

namespace HappyCenter.View
{
    /// <summary>
    /// Logique d'interaction pour VoirActivite.xaml
    /// </summary>
    public partial class VoirActiviteCuisine : Window
    {
        //private Uri uriSource = "..\ressources\";
        // public byte[] data = new byte[10];
        public DateTime h_d = new DateTime(0, 0, 0, 8, 0, 0);
        public DateTime h_f = new DateTime(0, 0, 0, 10, 0, 0);
        private DayOfWeek jour;

        public VoirActiviteCuisine()
        {
            InitializeComponent();
            /** System.IO.MemoryStream stream = new MemoryStream();
             /**photo_activite.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
             data = stream.ToArray();
             hcBddDataContext contxt = new hcBddDataContext();
             contxt.Activites.InsertAllOnSubmit(new Activites()
             {
                 Nom = "Cuisine",
                 Description = "apprenez à cuisiner des plats simples et équilibrés par Jean H ",
                 Heure_Debut = new DateTime(0, 0, 0, 8, 0, 0),
                 Heure_Fin = new DateTime(0, 0, 0, 10, 0, 0),
                 Age_Min = 10,
                 Age_Max = 99,
                 Photo = "cuisine.png",
                 Etat = CalculEtat();
             }
             );**/
        }

        public string CalculEtat(string letat)
        {
            DateTime h = new DateTime;

            while (h.Now.Equals(h_d.AddHours(1)))
            {
                letat = "activité en cours";
                etat.Content = letat;
            }
            letat = "activité terminée";
            etat.Content
        }
    }
 }

