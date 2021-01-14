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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumForm));
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
            this.tbNumSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCategorie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCouverture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(44, 31);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(28, 13);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Titre";
            // 
            // labelAuteur
            // 
            this.labelAuteur.AutoSize = true;
            this.labelAuteur.Location = new System.Drawing.Point(44, 103);
            this.labelAuteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuteur.Name = "labelAuteur";
            this.labelAuteur.Size = new System.Drawing.Size(57, 13);
            this.labelAuteur.TabIndex = 1;
            this.labelAuteur.Text = "Scénariste";
            // 
            // labelDessinateur
            // 
            this.labelDessinateur.AutoSize = true;
            this.labelDessinateur.Location = new System.Drawing.Point(44, 129);
            this.labelDessinateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDessinateur.Name = "labelDessinateur";
            this.labelDessinateur.Size = new System.Drawing.Size(63, 13);
            this.labelDessinateur.TabIndex = 2;
            this.labelDessinateur.Text = "Dessinateur";
            // 
            // labelEditeur
            // 
            this.labelEditeur.AutoSize = true;
            this.labelEditeur.Location = new System.Drawing.Point(44, 182);
            this.labelEditeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditeur.Name = "labelEditeur";
            this.labelEditeur.Size = new System.Drawing.Size(40, 13);
            this.labelEditeur.TabIndex = 3;
            this.labelEditeur.Text = "Éditeur";
            // 
            // labelSerie
            // 
            this.labelSerie.AutoSize = true;
            this.labelSerie.Location = new System.Drawing.Point(44, 55);
            this.labelSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSerie.Name = "labelSerie";
            this.labelSerie.Size = new System.Drawing.Size(31, 13);
            this.labelSerie.TabIndex = 4;
            this.labelSerie.Text = "Série";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(44, 208);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 5;
            this.labelGenre.Text = "Genre";
            // 
            // pictureBoxCouverture
            // 
            this.pictureBoxCouverture.Location = new System.Drawing.Point(327, 27);
            this.pictureBoxCouverture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCouverture.Name = "pictureBoxCouverture";
            this.pictureBoxCouverture.Size = new System.Drawing.Size(170, 221);
            this.pictureBoxCouverture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCouverture.TabIndex = 6;
            this.pictureBoxCouverture.TabStop = false;
            // 
            // tbTitre
            // 
            this.tbTitre.Enabled = false;
            this.tbTitre.Location = new System.Drawing.Point(121, 27);
            this.tbTitre.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.ReadOnly = true;
            this.tbTitre.Size = new System.Drawing.Size(154, 20);
            this.tbTitre.TabIndex = 8;
            // 
            // tbAuteur
            // 
            this.tbAuteur.Enabled = false;
            this.tbAuteur.Location = new System.Drawing.Point(121, 99);
            this.tbAuteur.Margin = new System.Windows.Forms.Padding(2);
            this.tbAuteur.Name = "tbAuteur";
            this.tbAuteur.ReadOnly = true;
            this.tbAuteur.Size = new System.Drawing.Size(154, 20);
            this.tbAuteur.TabIndex = 9;
            // 
            // tbEditeur
            // 
            this.tbEditeur.Enabled = false;
            this.tbEditeur.Location = new System.Drawing.Point(121, 178);
            this.tbEditeur.Margin = new System.Windows.Forms.Padding(2);
            this.tbEditeur.Name = "tbEditeur";
            this.tbEditeur.ReadOnly = true;
            this.tbEditeur.Size = new System.Drawing.Size(154, 20);
            this.tbEditeur.TabIndex = 11;
            // 
            // tbDessinateur
            // 
            this.tbDessinateur.Enabled = false;
            this.tbDessinateur.Location = new System.Drawing.Point(121, 124);
            this.tbDessinateur.Margin = new System.Windows.Forms.Padding(2);
            this.tbDessinateur.Name = "tbDessinateur";
            this.tbDessinateur.ReadOnly = true;
            this.tbDessinateur.Size = new System.Drawing.Size(154, 20);
            this.tbDessinateur.TabIndex = 10;
            // 
            // tbGenre
            // 
            this.tbGenre.Enabled = false;
            this.tbGenre.Location = new System.Drawing.Point(121, 203);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(2);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.ReadOnly = true;
            this.tbGenre.Size = new System.Drawing.Size(154, 20);
            this.tbGenre.TabIndex = 13;
            // 
            // tbSerie
            // 
            this.tbSerie.Enabled = false;
            this.tbSerie.Location = new System.Drawing.Point(121, 51);
            this.tbSerie.Margin = new System.Windows.Forms.Padding(2);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.ReadOnly = true;
            this.tbSerie.Size = new System.Drawing.Size(154, 20);
            this.tbSerie.TabIndex = 12;
            // 
            // tbNumSerie
            // 
            this.tbNumSerie.Enabled = false;
            this.tbNumSerie.Location = new System.Drawing.Point(121, 75);
            this.tbNumSerie.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumSerie.Name = "tbNumSerie";
            this.tbNumSerie.ReadOnly = true;
            this.tbNumSerie.Size = new System.Drawing.Size(154, 20);
            this.tbNumSerie.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tome";
            // 
            // tbCategorie
            // 
            this.tbCategorie.Enabled = false;
            this.tbCategorie.Location = new System.Drawing.Point(121, 227);
            this.tbCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.tbCategorie.Name = "tbCategorie";
            this.tbCategorie.ReadOnly = true;
            this.tbCategorie.Size = new System.Drawing.Size(154, 20);
            this.tbCategorie.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Catégorie";
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 265);
            this.Controls.Add(this.tbCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumSerie);
            this.Controls.Add(this.label1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlbumForm";
            this.Text = "Descripition album";
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
        private System.Windows.Forms.TextBox tbNumSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCategorie;
        private System.Windows.Forms.Label label2;
    }
}