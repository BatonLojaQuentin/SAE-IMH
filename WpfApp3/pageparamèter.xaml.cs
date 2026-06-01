using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp3
{
    public partial class pageparamètre : Window
    {
        public pageparamètre()
        {
            InitializeComponent();
        }

        private void BtnFermer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Paramètres sauvegardés !");
            this.Close();
        }
    }
}