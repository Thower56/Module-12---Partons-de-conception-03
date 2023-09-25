using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12___Patrons_de_conception_03
{
    [Description("Filtre Noir et Blanc")]
    public class TraitementImageConvertirNoirEtBlanc : ITraitementImage
    {
        [Browsable(false)]
        public ITraitementImage Suivant { get; set; }

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
                raw[l3] = luminance;
                raw[l3 + 1] = luminance;
                raw[l3 + 2] = luminance;
            }
            this.Suivant?.Traiter(p_image);
        }
        public override string ToString()
        {
            return "Filtre Noir et Blanc";
        }
    }
}
