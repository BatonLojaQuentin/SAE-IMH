using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp3
{
    public partial class ChoixAdversaireWindow : Window
    {
        public ChoixAdversaireWindow()
        {
            InitializeComponent();

            // MAGIE : La fenêtre lit la police du cerveau. 
            // Tous les textes à l'intérieur vont s'adapter d'un coup !
            this.FontSize = ConfigurationJeu.TaillePolice;
        }

        private void BtnLancer_Click(object sender, RoutedEventArgs e)
        {
            // On sauvegarde le choix de l'adversaire
            if (RadRobot.IsChecked == true)
            {
                ConfigurationJeu.TypeAdversaire = "Robot";
            }
            else
            {
                ConfigurationJeu.TypeAdversaire = "Humain";
            }

            MessageBox.Show($"Partie lancée contre : {ConfigurationJeu.TypeAdversaire} !\n" +
                            $"Couleur de vos pions : {ConfigurationJeu.CouleurPieces}");

            // Ici, tu ouvriras ta future fenêtre de jeu "GrillePuissance4Window"
            this.Close();
        }
    }
}
