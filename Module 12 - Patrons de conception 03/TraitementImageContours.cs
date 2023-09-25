using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12___Patrons_de_conception_03
{
    [Description("Filtre passe-haut")]
    public class TraitementImageContours : TraitementImageMasque
    {
        public TraitementImageContours()
        {
            Transformation = TraiterDonnees;
        }
        private static byte TraiterDonnees(byte[] p_donnees)
        {
            int coeficientCentrale = p_donnees.Length - 1;
            int posCentrale = p_donnees.Length / 2;
            int somme = 0;
            for (int i = 0; i < posCentrale; i++)
            {
                somme -= p_donnees[i];
            }
            somme += coeficientCentrale * p_donnees[posCentrale];
            for (int i = posCentrale + 1; i < p_donnees.Length; i++)
            {
                somme -= p_donnees[i];
            }
            return (byte)(somme / p_donnees.Length);
        }

        public override string ToString() 
        {
            return "Filtre passe-haut";
        }
    }
}
