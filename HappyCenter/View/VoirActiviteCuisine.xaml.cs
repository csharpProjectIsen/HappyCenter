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
    /// Logique d'interaction pour VoirActiviteCuisine.xaml
    /// </summary>
    public partial class VoirActiviteCuisine : Window
    {
        //private Uri uriSource = "..\ressources\";
        // public byte[] data = new byte[10];
       // public string h_d = new DateTime().ToString("08:00");
        public DateTime temps = new DateTime(2016, 5, 2, 8, 0, 0);
        public string jour = "mardi";

        public VoirActiviteCuisine()
        {
            InitializeComponent();
            /** System.IO.MemoryStream stream = new MemoryStream();
             photo_activite.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
             data = stream.ToArray();
             hcBddDataContext contxt = new hcBddDataContext();
             contxt.Activites.InsertAllOnSubmit(new Activites()
             {
                 Nom = "Cuisine",
                 Description = "apprenez à cuisiner des plats simples et équilibrés par Jean H ",
                 Heure_Debut = new DateTime(2016, 5, 2, 8, 0, 0),
                 Heure_Fin = new DateTime(2016, 5, 2, 10, 0, 0),
                 Age_Min = 10,
                 Age_Max = 99,
                 Photo = "cuisine.png",
                 Etat = CalculEtat();
             }
             );**/
            // etat.Content = CalculEtat();
        }

        public string CalculEtat()
        {
            DateTime h = DateTime.Now;
            string jour_actuel = h.DayOfWeek.ToString();
            TimeSpan diff = h - temps;
            double hours = diff.TotalHours;

            while (hours<2)
            {
               string letat = "activité en cours";
                if(jour_actuel == jour)
                {
                    return letat;
                }
                
            }
            string letatfin = "activité terminée";
            return letatfin;
        }
    }
 }

