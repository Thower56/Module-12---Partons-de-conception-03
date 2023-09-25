using System;

namespace Module_12___Patrons_de_conception_03
{
    public interface ITraitementImage : ICloneable
    {
        ITraitementImage Suivant { get; set; }
        void Traiter(ImageManipulable p_image);
    }
}