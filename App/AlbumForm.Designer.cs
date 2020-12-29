namespace ProjetGL
{
    partial class AlbumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelAuteur = new System.Windows.Forms.Label();
            this.labelDessinateur = new System.Windows.Forms.Label();
            this.labelEditeur = new System.Windows.Forms.Label();
            this.labelSerie = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.pictureBoxCouverture = new System.Windows.Forms.PictureBox();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbAuteur = new System.Windows.Forms.TextBox();
            this.tbEditeur = new System.Windows.Forms.TextBox();
            this.tbDessinateur = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbSerie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCouverture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(45, 48);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(28, 13);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Titre";
            // 
            // labelAuteur
            // 
            this.labelAuteur.AutoSize = true;
            this.labelAuteur.Location = new System.Drawing.Point(45, 72);
            this.labelAuteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuteur.Name = "labelAuteur";
            this.labelAuteur.Size = new System.Drawing.Size(57, 13);
            this.labelAuteur.TabIndex = 1;
            this.labelAuteur.Text = "Scénariste";
            // 
            // labelDessinateur
            // 
            this.labelDessinateur.AutoSize = true;
            this.labelDessinateur.Location = new System.Drawing.Point(45, 98);
            this.labelDessinateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDessinateur.Name = "labelDessinateur";
            this.labelDessinateur.Size = new System.Drawing.Size(63, 13);
            this.labelDessinateur.TabIndex = 2;
            this.labelDessinateur.Text = "Dessinateur";
            // 
            // labelEditeur
            // 
            this.labelEditeur.AutoSize = true;
            this.labelEditeur.Location = new System.Drawing.Point(45, 122);
            this.labelEditeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditeur.Name = "labelEditeur";
            this.labelEditeur.Size = new System.Drawing.Size(40, 13);
            this.labelEditeur.TabIndex = 3;
            this.labelEditeur.Text = "Éditeur";
            // 
            // labelSerie
            // 
            this.labelSerie.AutoSize = true;
            this.labelSerie.Location = new System.Drawing.Point(45, 194);
            this.labelSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSerie.Name = "labelSerie";
            this.labelSerie.Size = new System.Drawing.Size(31, 13);
            this.labelSerie.TabIndex = 4;
            this.labelSerie.Text = "Série";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(45, 219);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 5;
            this.labelGenre.Text = "Genre";
            // 
            // pictureBoxCouverture
            // 
            this.pictureBoxCouverture.Location = new System.Drawing.Point(355, 48);
            this.pictureBoxCouverture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCouverture.Name = "pictureBoxCouverture";
            this.pictureBoxCouverture.Size = new System.Drawing.Size(142, 184);
            this.pictureBoxCouverture.TabIndex = 6;
            this.pictureBoxCouverture.TabStop = false;
            // 
            // tbTitre
            // 
            this.tbTitre.Enabled = false;
            this.tbTitre.Location = new System.Drawing.Point(122, 44);
            this.tbTitre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.ReadOnly = true;
            this.tbTitre.Size = new System.Drawing.Size(154, 20);
            this.tbTitre.TabIndex = 8;
            // 
            // tbAuteur
            // 
            this.tbAuteur.Enabled = false;
            this.tbAuteur.Location = new System.Drawing.Point(122, 68);
            this.tbAuteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAuteur.Name = "tbAuteur";
            this.tbAuteur.ReadOnly = true;
            this.tbAuteur.Size = new System.Drawing.Size(154, 20);
            this.tbAuteur.TabIndex = 9;
            // 
            // tbEditeur
            // 
            this.tbEditeur.Enabled = false;
            this.tbEditeur.Location = new System.Drawing.Point(122, 118);
            this.tbEditeur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEditeur.Name = "tbEditeur";
            this.tbEditeur.ReadOnly = true;
            this.tbEditeur.Size = new System.Drawing.Size(154, 20);
            this.tbEditeur.TabIndex = 11;
            // 
            // tbDessinateur
            // 
            this.tbDessinateur.Enabled = false;
            this.tbDessinateur.Location = new System.Drawing.Point(122, 93);
            this.tbDessinateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDessinateur.Name = "tbDessinateur";
            this.tbDessinateur.ReadOnly = true;
            this.tbDessinateur.Size = new System.Drawing.Size(154, 20);
            this.tbDessinateur.TabIndex = 10;
            // 
            // tbGenre
            // 
            this.tbGenre.Enabled = false;
            this.tbGenre.Location = new System.Drawing.Point(122, 214);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.ReadOnly = true;
            this.tbGenre.Size = new System.Drawing.Size(154, 20);
            this.tbGenre.TabIndex = 13;
            // 
            // tbSerie
            // 
            this.tbSerie.Enabled = false;
            this.tbSerie.Location = new System.Drawing.Point(122, 190);
            this.tbSerie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.ReadOnly = true;
            this.tbSerie.Size = new System.Drawing.Size(154, 20);
            this.tbSerie.TabIndex = 12;
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbSerie);
            this.Controls.Add(this.tbEditeur);
            this.Controls.Add(this.tbDessinateur);
            this.Controls.Add(this.tbAuteur);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.pictureBoxCouverture);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelSerie);
            this.Controls.Add(this.labelEditeur);
            this.Controls.Add(this.labelDessinateur);
            this.Controls.Add(this.labelAuteur);
            this.Controls.Add(this.labelTitre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlbumForm";
            this.Text = "AlbumForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCouverture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelAuteur;
        private System.Windows.Forms.Label labelDessinateur;
        private System.Windows.Forms.Label labelEditeur;
        private System.Windows.Forms.Label labelSerie;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.PictureBox pictureBoxCouverture;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.TextBox tbAuteur;
        private System.Windows.Forms.TextBox tbEditeur;
        private System.Windows.Forms.TextBox tbDessinateur;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbSerie;
    }
}