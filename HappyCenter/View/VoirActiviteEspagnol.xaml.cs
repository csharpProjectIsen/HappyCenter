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
    /// Logique d'interaction pour VoirActiviteEspagnol.xaml
    /// </summary>
    public partial class VoirActiviteEspagnol : Window
    {
        public DateTime temps = new DateTime(2016, 5, 2, 10, 0, 0);
        public string jour = "jeudi";

        public VoirActiviteEspagnol()
        {
            InitializeComponent();
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

