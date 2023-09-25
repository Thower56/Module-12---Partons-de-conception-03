using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_12___Patrons_de_conception_03
{
    public partial class Form1 : Form
    {
        private ImageManipulable m_imageManipulable;
        public Form1()
        {
            InitializeComponent();
        }

        private void pControlSuiteTrai_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scSuiteTraitements_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTraitementAAjouter.Items.Add(new object[] { UtilitaireTraitements.RechercherTraitementsImage() });
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Fichiers image (*.jpeg)|*.jpeg;";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    m_imageManipulable = new ImageManipulable(openFileDialog.FileName);
                    pbImage.Image = m_imageManipulable.Image;
                }
            }
        }

        private void bSuiteTraitementDeplacerHaut_Click(object sender, EventArgs e)
        {
            if (lbSuiteTraitementsAAppliquer.SelectedIndex > 0) 
            {
                lbSuiteTraitementsAAppliquer.SelectedIndex--;
            }
        }

        private void bSuiteTraitementDeplacerBas_Click(object sender, EventArgs e)
        {
            if (lbSuiteTraitementsAAppliquer.SelectedIndex < (lbSuiteTraitementsAAppliquer.Items.Count - 1))
            {
                lbSuiteTraitementsAAppliquer.SelectedIndex++;
            }
        }

        private void bSupprimerTraitement_Click(object sender, EventArgs e)
        {
            lbSuiteTraitementsAAppliquer.Items.RemoveAt(lbSuiteTraitementsAAppliquer.SelectedIndex);
        }

        private void bAjouterTraitement_Click(object sender, EventArgs e)
        {
            lbSuiteTraitementsAAppliquer.Items.Add(cbTraitementAAjouter.SelectedItem);
        }
    }
}
