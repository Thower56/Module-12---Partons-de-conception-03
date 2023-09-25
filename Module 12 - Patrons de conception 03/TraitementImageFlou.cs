using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12___Patrons_de_conception_03
{
    [Description("Filtre Flou")]
    public class TraitementImageFlou : TraitementImageMasque
    {
        private static byte TraiterDonnees(byte[] p_donnees)
        {
            int somme = 0;
            for (int i = 0; i < p_donnees.Length; i++)
            {
                somme += p_donnees[i];
            }

            return (byte)(somme / p_donnees.Length);
        }
        public override string ToString()
        {
            return "Filtre Flou";
        }
    }
}
