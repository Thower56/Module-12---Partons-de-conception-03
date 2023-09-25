namespace Module_12___Patrons_de_conception_03
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scPrincipal = new System.Windows.Forms.SplitContainer();
            this.scSuiteTraitements = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bAppliquerSuiteTraitement = new System.Windows.Forms.Button();
            this.lbSuiteTraitementsAAppliquer = new System.Windows.Forms.ListBox();
            this.pControlSuiteTrai = new System.Windows.Forms.Panel();
            this.bSupprimerTraitement = new System.Windows.Forms.Button();
            this.bAjouterTraitement = new System.Windows.Forms.Button();
            this.bSuiteTraitementDeplacerBas = new System.Windows.Forms.Button();
            this.bSuiteTraitementDeplacerHaut = new System.Windows.Forms.Button();
            this.cbTraitementAAjouter = new System.Windows.Forms.ComboBox();
            this.pgProprieteTraitementSelectionne = new System.Windows.Forms.PropertyGrid();
            this.pCanvas = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).BeginInit();
            this.scPrincipal.Panel1.SuspendLayout();
            this.scPrincipal.Panel2.SuspendLayout();
            this.scPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSuiteTraitements)).BeginInit();
            this.scSuiteTraitements.Panel1.SuspendLayout();
            this.scSuiteTraitements.Panel2.SuspendLayout();
            this.scSuiteTraitements.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pControlSuiteTrai.SuspendLayout();
            this.pCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFichier
            // 
            this.tsmiFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem});
            this.tsmiFichier.Name = "tsmiFichier";
            this.tsmiFichier.Size = new System.Drawing.Size(66, 24);
            this.tsmiFichier.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // scPrincipal
            // 
            this.scPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scPrincipal.Location = new System.Drawing.Point(0, 30);
            this.scPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scPrincipal.Name = "scPrincipal";
            // 
            // scPrincipal.Panel1
            // 
            this.scPrincipal.Panel1.Controls.Add(this.scSuiteTraitements);
            // 
            // scPrincipal.Panel2
            // 
            this.scPrincipal.Panel2.Controls.Add(this.pCanvas);
            this.scPrincipal.Size = new System.Drawing.Size(818, 415);
            this.scPrincipal.SplitterDistance = 259;
            this.scPrincipal.SplitterWidth = 5;
            this.scPrincipal.TabIndex = 1;
            // 
            // scSuiteTraitements
            // 
            this.scSuiteTraitements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scSuiteTraitements.Location = new System.Drawing.Point(4, 4);
            this.scSuiteTraitements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scSuiteTraitements.Name = "scSuiteTraitements";
            this.scSuiteTraitements.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSuiteTraitements.Panel1
            // 
            this.scSuiteTraitements.Panel1.Controls.Add(this.panel2);
            this.scSuiteTraitements.Panel1.Controls.Add(this.lbSuiteTraitementsAAppliquer);
            this.scSuiteTraitements.Panel1.Controls.Add(this.pControlSuiteTrai);
            this.scSuiteTraitements.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.scSuiteTraitements.Panel1MinSize = 60;
            // 
            // scSuiteTraitements.Panel2
            // 
            this.scSuiteTraitements.Panel2.Controls.Add(this.pgProprieteTraitementSelectionne);
            this.scSuiteTraitements.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.scSuiteTraitements_Panel2_Paint);
            this.scSuiteTraitements.Size = new System.Drawing.Size(251, 406);
            this.scSuiteTraitements.SplitterDistance = 177;
            this.scSuiteTraitements.SplitterWidth = 5;
            this.scSuiteTraitements.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bAppliquerSuiteTraitement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 41);
            this.panel2.TabIndex = 2;
            // 
            // bAppliquerSuiteTraitement
            // 
            this.bAppliquerSuiteTraitement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAppliquerSuiteTraitement.Location = new System.Drawing.Point(0, 0);
            this.bAppliquerSuiteTraitement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAppliquerSuiteTraitement.Name = "bAppliquerSuiteTraitement";
            this.bAppliquerSuiteTraitement.Size = new System.Drawing.Size(251, 41);
            this.bAppliquerSuiteTraitement.TabIndex = 0;
            this.bAppliquerSuiteTraitement.Text = "Appliquer";
            this.bAppliquerSuiteTraitement.UseVisualStyleBackColor = true;
            this.bAppliquerSuiteTraitement.Click += new System.EventHandler(this.bAppliquerSuiteTraitement_Click);
            // 
            // lbSuiteTraitementsAAppliquer
            // 
            this.lbSuiteTraitementsAAppliquer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSuiteTraitementsAAppliquer.FormattingEnabled = true;
            this.lbSuiteTraitementsAAppliquer.ItemHeight = 16;
            this.lbSuiteTraitementsAAppliquer.Location = new System.Drawing.Point(0, 75);
            this.lbSuiteTraitementsAAppliquer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSuiteTraitementsAAppliquer.Name = "lbSuiteTraitementsAAppliquer";
            this.lbSuiteTraitementsAAppliquer.Size = new System.Drawing.Size(251, 102);
            this.lbSuiteTraitementsAAppliquer.TabIndex = 1;
            this.lbSuiteTraitementsAAppliquer.SelectedIndexChanged += new System.EventHandler(this.lbSuiteTraitementsAAppliquer_SelectedIndexChanged);
            // 
            // pControlSuiteTrai
            // 
            this.pControlSuiteTrai.Controls.Add(this.bSupprimerTraitement);
            this.pControlSuiteTrai.Controls.Add(this.bAjouterTraitement);
            this.pControlSuiteTrai.Controls.Add(this.bSuiteTraitementDeplacerBas);
            this.pControlSuiteTrai.Controls.Add(this.bSuiteTraitementDeplacerHaut);
            this.pControlSuiteTrai.Controls.Add(this.cbTraitementAAjouter);
            this.pControlSuiteTrai.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControlSuiteTrai.Location = new System.Drawing.Point(0, 0);
            this.pControlSuiteTrai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pControlSuiteTrai.Name = "pControlSuiteTrai";
            this.pControlSuiteTrai.Size = new System.Drawing.Size(251, 75);
            this.pControlSuiteTrai.TabIndex = 0;
            this.pControlSuiteTrai.Paint += new System.Windows.Forms.PaintEventHandler(this.pControlSuiteTrai_Paint);
            // 
            // bSupprimerTraitement
            // 
            this.bSupprimerTraitement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSupprimerTraitement.Location = new System.Drawing.Point(211, 37);
            this.bSupprimerTraitement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSupprimerTraitement.Name = "bSupprimerTraitement";
            this.bSupprimerTraitement.Size = new System.Drawing.Size(35, 28);
            this.bSupprimerTraitement.TabIndex = 4;
            this.bSupprimerTraitement.Text = "-";
            this.bSupprimerTraitement.UseVisualStyleBackColor = true;
            this.bSupprimerTraitement.Click += new System.EventHandler(this.bSupprimerTraitement_Click);
            // 
            // bAjouterTraitement
            // 
            this.bAjouterTraitement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAjouterTraitement.Location = new System.Drawing.Point(167, 37);
            this.bAjouterTraitement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAjouterTraitement.Name = "bAjouterTraitement";
            this.bAjouterTraitement.Size = new System.Drawing.Size(37, 28);
            this.bAjouterTraitement.TabIndex = 3;
            this.bAjouterTraitement.Text = "+";
            this.bAjouterTraitement.UseVisualStyleBackColor = true;
            this.bAjouterTraitement.Click += new System.EventHandler(this.bAjouterTraitement_Click);
            // 
            // bSuiteTraitementDeplacerBas
            // 
            this.bSuiteTraitementDeplacerBas.Location = new System.Drawing.Point(56, 37);
            this.bSuiteTraitementDeplacerBas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSuiteTraitementDeplacerBas.Name = "bSuiteTraitementDeplacerBas";
            this.bSuiteTraitementDeplacerBas.Size = new System.Drawing.Size(36, 28);
            this.bSuiteTraitementDeplacerBas.TabIndex = 2;
            this.bSuiteTraitementDeplacerBas.Text = "↓";
            this.bSuiteTraitementDeplacerBas.UseVisualStyleBackColor = true;
            this.bSuiteTraitementDeplacerBas.Click += new System.EventHandler(this.bSuiteTraitementDeplacerBas_Click);
            // 
            // bSuiteTraitementDeplacerHaut
            // 
            this.bSuiteTraitementDeplacerHaut.Location = new System.Drawing.Point(7, 37);
            this.bSuiteTraitementDeplacerHaut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSuiteTraitementDeplacerHaut.Name = "bSuiteTraitementDeplacerHaut";
            this.bSuiteTraitementDeplacerHaut.Size = new System.Drawing.Size(36, 28);
            this.bSuiteTraitementDeplacerHaut.TabIndex = 1;
            this.bSuiteTraitementDeplacerHaut.Text = "↑";
            this.bSuiteTraitementDeplacerHaut.UseVisualStyleBackColor = true;
            this.bSuiteTraitementDeplacerHaut.Click += new System.EventHandler(this.bSuiteTraitementDeplacerHaut_Click);
            // 
            // cbTraitementAAjouter
            // 
            this.cbTraitementAAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTraitementAAjouter.FormattingEnabled = true;
            this.cbTraitementAAjouter.Location = new System.Drawing.Point(4, 4);
            this.cbTraitementAAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTraitementAAjouter.Name = "cbTraitementAAjouter";
            this.cbTraitementAAjouter.Size = new System.Drawing.Size(240, 24);
            this.cbTraitementAAjouter.TabIndex = 0;
            // 
            // pgProprieteTraitementSelectionne
            // 
            this.pgProprieteTraitementSelectionne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgProprieteTraitementSelectionne.Location = new System.Drawing.Point(0, 0);
            this.pgProprieteTraitementSelectionne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgProprieteTraitementSelectionne.Name = "pgProprieteTraitementSelectionne";
            this.pgProprieteTraitementSelectionne.Size = new System.Drawing.Size(251, 224);
            this.pgProprieteTraitementSelectionne.TabIndex = 3;
            this.pgProprieteTraitementSelectionne.Click += new System.EventHandler(this.pgProprieteTraitementSelectionne_Click);
            // 
            // pCanvas
            // 
            this.pCanvas.AutoScroll = true;
            this.pCanvas.BackColor = System.Drawing.Color.White;
            this.pCanvas.Controls.Add(this.pbImage);
            this.pCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCanvas.Location = new System.Drawing.Point(0, 0);
            this.pCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(554, 415);
            this.pCanvas.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(554, 415);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 454);
            this.Controls.Add(this.scPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(746, 441);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scPrincipal.Panel1.ResumeLayout(false);
            this.scPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).EndInit();
            this.scPrincipal.ResumeLayout(false);
            this.scSuiteTraitements.Panel1.ResumeLayout(false);
            this.scSuiteTraitements.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSuiteTraitements)).EndInit();
            this.scSuiteTraitements.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pControlSuiteTrai.ResumeLayout(false);
            this.pCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFichier;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scPrincipal;
        private System.Windows.Forms.PropertyGrid pgProprieteTraitementSelectionne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bAppliquerSuiteTraitement;
        private System.Windows.Forms.ListBox lbSuiteTraitementsAAppliquer;
        private System.Windows.Forms.Panel pControlSuiteTrai;
        private System.Windows.Forms.Button bSupprimerTraitement;
        private System.Windows.Forms.Button bAjouterTraitement;
        private System.Windows.Forms.Button bSuiteTraitementDeplacerBas;
        private System.Windows.Forms.Button bSuiteTraitementDeplacerHaut;
        private System.Windows.Forms.ComboBox cbTraitementAAjouter;
        private System.Windows.Forms.Panel pCanvas;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.SplitContainer scSuiteTraitements;
    }
}

