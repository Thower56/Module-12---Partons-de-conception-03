using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12___Patrons_de_conception_03
{
    [Description("Filtre Seuil Luminance")]
    public class TraitementImageSeuilLuminance : ITraitementImage
    {
        public int Seuil { get; set; }
        public ITraitementImage Suivant { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Traiter(ImageManipulable p_image)
        {
            byte[] raw = p_image.Raw;
            for (int longueur = 0; longueur < raw.Length / 3; longueur++)
            {
                int l3 = longueur * 3;
                byte luminance = (byte)((raw[l3] + raw[l3 + 1] + raw[l3 + 2]) / 3);
                byte valeur = 0;
                if (luminance > this.Seuil)
                {
                    valeur = 255;
                }
                raw[l3] = valeur;
                raw[l3 + 1] = valeur;
                raw[l3 + 2] = valeur;
            }

            this.Suivant?.Traiter(p_image);
        }
    }
}
