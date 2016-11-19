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
using System.Net;
using System.Net.Sockets;

namespace HappyCenter.View
{
    /// <summary>
    /// Interaction logic for VoirChat.xaml
    /// </summary>
    public partial class VoirChat : Window
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        string textLocalIp, textRemoteIp;
        int textLocalPort, textRemotePort;
        public VoirChat()
        {
            InitializeComponent();

            //Mise en place du socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Obtenir l'adresse IP de l'utilisateur
            textLocalIp = GetLocalIP();
            textRemoteIp = GetLocalIP();

            // attribution des ports
            textLocalPort = 80;
            textRemotePort = 81;
        }

        //Méthode d'obtention de l'adresse IP local
        private string GetLocalIP(){

            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }

            return "127.0.0.1";   
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

        //Bouton connexion du Chat
        private void btnConnexion_Click(object sender, RoutedEventArgs e)
        {
            //liaison du socket
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp), Convert.ToInt32(textLocalPort));
            sck.Bind(epLocal);

            //Connexion à l'IP de commande
            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp), Convert.ToInt32(textRemotePort));
            sck.Connect(epRemote);

            //Ecoute d'un port spécifique
            // sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            //Message Box
            MessageBox.Show("Vous êtes maintenant connecté(e), vous pouvez discuter avec l'admin !");

        }
        // Méthode du MessageCallBack
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //Conversion de byte en string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //Ajouter ce message dans la listeBox
                listMessage.Items.Add("Admin : " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Boyton envoyer du Chat
        private void button_Envoyer_Click(object sender, RoutedEventArgs e)
        {
            //Convertir le message string en byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = aEncoding.GetBytes(textMessage.Text);

            //Envoie du message encodé
            sck.Send(sendingMessage);

            //Ajout à la listbox
            listMessage.Items.Add("Moi : "+ textMessage.Text);
            textMessage.Text = "";

        }

        ////Onglet Contact de la barre Menu
        private void MenuItem_Contact_Click(object sender, RoutedEventArgs e)
        {
            VoirContact contact = new VoirContact();
            contact.Show();
            this.Close();
        }
    }
}
