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
    /// Logique d'interaction pour VoirActivite.xaml
    /// </summary>
    public partial class VoirActivite : Window
    {
        public VoirActivite()
        {
            InitializeComponent();
        }

        hcBddDataContext contxt = new hcBddDataContext();
        
        /**contxt.Activites.InsertAllOnSubmit(new Activites()
        {
            Nom = "Cuisine",
            Description = "apprenez à cuisiner des plats simples et équilibrés par Jean H ",
            Heure_Debut = new DateTime(0, 0, 0, 8, 0, 0),
            Heure_Fin = new DateTime(0, 0, 0, 10, 0, 0),
            Age_Min = 10,
            Age_Max = 99,
          });
        /**byte[] data;
        using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                data = stream.ToArray();
            };**/
       

    }
}