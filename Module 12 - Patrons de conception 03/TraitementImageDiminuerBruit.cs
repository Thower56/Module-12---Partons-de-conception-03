using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12___Patrons_de_conception_03
{
    [Description("Filtre Bruit")]
    public class TraitementImageDiminuerBruit : TraitementImageMasque
    {
        private static byte TraiterDonnees(byte[] p_donnees)
        {
            Array.Sort(p_donnees);

            return p_donnees[p_donnees.Length / 2];
        }
        public override string ToString()
        {
            return "Filtre Bruit";
        }
    }
    
}
