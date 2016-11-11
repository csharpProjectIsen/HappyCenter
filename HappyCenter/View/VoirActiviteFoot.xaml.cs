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
    /// Logique d'interaction pour VoirActiviteFoot.xaml
    /// </summary>
    public partial class VoirActiviteFoot : Window
    {
       
        public DateTime temps1 = new DateTime(2016, 11, 11, 16, 00, 00);
        public DateTime temps2 = new DateTime(2016, 11, 04, 10, 00, 00);
        public string jour1 = "jeudi";
        public string jour2 = "vendredi";

        public VoirActiviteFoot()
        {
            InitializeComponent();
        }

        public string CalculEtat()
        {
            DateTime h = DateTime.Now;
            string jour_actuel = h.DayOfWeek.ToString();
            TimeSpan diff1 = h - temps1;
            TimeSpan diff2 = h - temps2;
            double hours1 = diff1.TotalHours;
            double hours2 = diff2.TotalHours;

            while (hours1<2 || hours2<2)
            {
               string letat = "activité en cours";
                if(jour_actuel == jour1 || jour_actuel == jour2)
                {
                    return letat;
                }
                
            }
            string letatfin = "activité terminée";
            return letatfin;
        }
    }
 }

