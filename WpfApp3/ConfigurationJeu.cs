using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp3
{
    public static class ConfigurationJeu
    {
        // Ce fichier va stocker tes choix en mémoire d'une page à l'autre
        public static double TaillePolice { get; set; } = 14;
        public static string CouleurPieces { get; set; } = "Rouge";
        public static string FormePieces { get; set; } = "Rond";
        public static string CouleurGrille { get; set; } = "Bleu";
        public static string TypeAdversaire { get; set; } = "Humain";
    }
}