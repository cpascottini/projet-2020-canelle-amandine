﻿namespace ProjetGL
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabCtrlAlbums = new System.Windows.Forms.TabControl();
            this.tabPageMyAlbums = new System.Windows.Forms.TabPage();
            this.dgvMyAlbums = new System.Windows.Forms.DataGridView();
            this.columnMySerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyNumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyDessinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabWishlist = new System.Windows.Forms.TabPage();
            this.dgvWishlist = new System.Windows.Forms.DataGridView();
            this.columnWishSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWishNumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWishTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWishScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWishDessinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAllAlbums = new System.Windows.Forms.TabPage();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.labelPasDeResultat = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.dgvAllAlbums = new System.Windows.Forms.DataGridView();
            this.columnAllSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAllTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAllScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAllDessinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyAlbums = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnWishlist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnAjouterAlbum = new System.Windows.Forms.Button();
            this.labelConsigne = new System.Windows.Forms.Label();
            this.tabCtrlAlbums.SuspendLayout();
            this.tabPageMyAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAlbums)).BeginInit();
            this.tabWishlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlist)).BeginInit();
            this.tabPageAllAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlAlbums
            // 
            this.tabCtrlAlbums.Controls.Add(this.tabPageMyAlbums);
            this.tabCtrlAlbums.Controls.Add(this.tabWishlist);
            this.tabCtrlAlbums.Controls.Add(this.tabPageAllAlbums);
            this.tabCtrlAlbums.Location = new System.Drawing.Point(10, 54);
            this.tabCtrlAlbums.Name = "tabCtrlAlbums";
            this.tabCtrlAlbums.SelectedIndex = 0;
            this.tabCtrlAlbums.Size = new System.Drawing.Size(696, 358);
            this.tabCtrlAlbums.TabIndex = 0;
            // 
            // tabPageMyAlbums
            // 
            this.tabPageMyAlbums.Controls.Add(this.dgvMyAlbums);
            this.tabPageMyAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageMyAlbums.Name = "tabPageMyAlbums";
            this.tabPageMyAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMyAlbums.Size = new System.Drawing.Size(688, 332);
            this.tabPageMyAlbums.TabIndex = 0;
            this.tabPageMyAlbums.Text = "Mes albums";
            this.tabPageMyAlbums.UseVisualStyleBackColor = true;
            // 
            // dgvMyAlbums
            // 
            this.dgvMyAlbums.AllowUserToAddRows = false;
            this.dgvMyAlbums.AllowUserToDeleteRows = false;
            this.dgvMyAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMySerie,
            this.columnMyNumSerie,
            this.columnMyTitre,
            this.columnMyScenariste,
            this.columnMyDessinateur});
            this.dgvMyAlbums.Location = new System.Drawing.Point(0, 0);
            this.dgvMyAlbums.Name = "dgvMyAlbums";
            this.dgvMyAlbums.ReadOnly = true;
            this.dgvMyAlbums.RowHeadersVisible = false;
            this.dgvMyAlbums.RowHeadersWidth = 51;
            this.dgvMyAlbums.Size = new System.Drawing.Size(688, 335);
            this.dgvMyAlbums.TabIndex = 0;
            this.dgvMyAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyAlbums_CellClick);
            // 
            // columnMySerie
            // 
            this.columnMySerie.HeaderText = "Série";
            this.columnMySerie.MinimumWidth = 6;
            this.columnMySerie.Name = "columnMySerie";
            this.columnMySerie.ReadOnly = true;
            this.columnMySerie.Width = 125;
            // 
            // columnMyNumSerie
            // 
            this.columnMyNumSerie.HeaderText = "N°";
            this.columnMyNumSerie.Name = "columnMyNumSerie";
            this.columnMyNumSerie.ReadOnly = true;
            this.columnMyNumSerie.Width = 30;
            // 
            // columnMyTitre
            // 
            this.columnMyTitre.HeaderText = "Titre";
            this.columnMyTitre.MinimumWidth = 6;
            this.columnMyTitre.Name = "columnMyTitre";
            this.columnMyTitre.ReadOnly = true;
            this.columnMyTitre.Width = 140;
            // 
            // columnMyScenariste
            // 
            this.columnMyScenariste.HeaderText = "Scénariste";
            this.columnMyScenariste.MinimumWidth = 6;
            this.columnMyScenariste.Name = "columnMyScenariste";
            this.columnMyScenariste.ReadOnly = true;
            this.columnMyScenariste.Width = 125;
            // 
            // columnMyDessinateur
            // 
            this.columnMyDessinateur.HeaderText = "Dessinateur";
            this.columnMyDessinateur.MinimumWidth = 6;
            this.columnMyDessinateur.Name = "columnMyDessinateur";
            this.columnMyDessinateur.ReadOnly = true;
            this.columnMyDessinateur.Width = 125;
            // 
            // tabWishlist
            // 
            this.tabWishlist.Controls.Add(this.dgvWishlist);
            this.tabWishlist.Location = new System.Drawing.Point(4, 22);
            this.tabWishlist.Margin = new System.Windows.Forms.Padding(2);
            this.tabWishlist.Name = "tabWishlist";
            this.tabWishlist.Padding = new System.Windows.Forms.Padding(2);
            this.tabWishlist.Size = new System.Drawing.Size(688, 332);
            this.tabWishlist.TabIndex = 2;
            this.tabWishlist.Text = "Wishlist";
            this.tabWishlist.UseVisualStyleBackColor = true;
            // 
            // dgvWishlist
            // 
            this.dgvWishlist.AllowUserToAddRows = false;
            this.dgvWishlist.AllowUserToDeleteRows = false;
            this.dgvWishlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWishlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnWishSerie,
            this.columnWishNumSerie,
            this.columnWishTitre,
            this.columnWishScenariste,
            this.columnWishDessinateur});
            this.dgvWishlist.Location = new System.Drawing.Point(0, 0);
            this.dgvWishlist.Margin = new System.Windows.Forms.Padding(2);
            this.dgvWishlist.Name = "dgvWishlist";
            this.dgvWishlist.ReadOnly = true;
            this.dgvWishlist.RowHeadersVisible = false;
            this.dgvWishlist.RowHeadersWidth = 51;
            this.dgvWishlist.RowTemplate.Height = 24;
            this.dgvWishlist.Size = new System.Drawing.Size(689, 335);
            this.dgvWishlist.TabIndex = 0;
            this.dgvWishlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWishlist_CellClick);
            // 
            // columnWishSerie
            // 
            this.columnWishSerie.HeaderText = "Série";
            this.columnWishSerie.MinimumWidth = 6;
            this.columnWishSerie.Name = "columnWishSerie";
            this.columnWishSerie.ReadOnly = true;
            this.columnWishSerie.Width = 125;
            // 
            // columnWishNumSerie
            // 
            this.columnWishNumSerie.HeaderText = "N°";
            this.columnWishNumSerie.Name = "columnWishNumSerie";
            this.columnWishNumSerie.ReadOnly = true;
            this.columnWishNumSerie.Width = 30;
            // 
            // columnWishTitre
            // 
            this.columnWishTitre.HeaderText = "Titre";
            this.columnWishTitre.MinimumWidth = 6;
            this.columnWishTitre.Name = "columnWishTitre";
            this.columnWishTitre.ReadOnly = true;
            this.columnWishTitre.Width = 140;
            // 
            // columnWishScenariste
            // 
            this.columnWishScenariste.HeaderText = "Scénariste";
            this.columnWishScenariste.MinimumWidth = 6;
            this.columnWishScenariste.Name = "columnWishScenariste";
            this.columnWishScenariste.ReadOnly = true;
            this.columnWishScenariste.Width = 125;
            // 
            // columnWishDessinateur
            // 
            this.columnWishDessinateur.HeaderText = "Dessinateur";
            this.columnWishDessinateur.MinimumWidth = 6;
            this.columnWishDessinateur.Name = "columnWishDessinateur";
            this.columnWishDessinateur.ReadOnly = true;
            this.columnWishDessinateur.Width = 125;
            // 
            // tabPageAllAlbums
            // 
            this.tabPageAllAlbums.Controls.Add(this.btnAnnuler);
            this.tabPageAllAlbums.Controls.Add(this.labelPasDeResultat);
            this.tabPageAllAlbums.Controls.Add(this.btnRecherche);
            this.tabPageAllAlbums.Controls.Add(this.tbRecherche);
            this.tabPageAllAlbums.Controls.Add(this.dgvAllAlbums);
            this.tabPageAllAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllAlbums.Name = "tabPageAllAlbums";
            this.tabPageAllAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllAlbums.Size = new System.Drawing.Size(688, 332);
            this.tabPageAllAlbums.TabIndex = 1;
            this.tabPageAllAlbums.Text = "Tous les albums";
            this.tabPageAllAlbums.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(597, 15);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // labelPasDeResultat
            // 
            this.labelPasDeResultat.AutoSize = true;
            this.labelPasDeResultat.BackColor = System.Drawing.Color.Transparent;
            this.labelPasDeResultat.Location = new System.Drawing.Point(182, 128);
            this.labelPasDeResultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasDeResultat.Name = "labelPasDeResultat";
            this.labelPasDeResultat.Size = new System.Drawing.Size(0, 13);
            this.labelPasDeResultat.TabIndex = 5;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(497, 16);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // tbRecherche
            // 
            this.tbRecherche.ForeColor = System.Drawing.Color.DarkGray;
            this.tbRecherche.Location = new System.Drawing.Point(135, 18);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(328, 20);
            this.tbRecherche.TabIndex = 2;
            this.tbRecherche.Text = "Recherchez une BD, une série, un auteur, un genre...";
            this.tbRecherche.Enter += new System.EventHandler(this.tbRecherche_Enter);
            // 
            // dgvAllAlbums
            // 
            this.dgvAllAlbums.AllowUserToAddRows = false;
            this.dgvAllAlbums.AllowUserToResizeColumns = false;
            this.dgvAllAlbums.AllowUserToResizeRows = false;
            this.dgvAllAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAllSerie,
            this.ColumnNumSerie,
            this.columnAllTitre,
            this.columnAllScenariste,
            this.columnAllDessinateur,
            this.columnMyAlbums,
            this.columnWishlist});
            this.dgvAllAlbums.Location = new System.Drawing.Point(0, 51);
            this.dgvAllAlbums.Name = "dgvAllAlbums";
            this.dgvAllAlbums.ReadOnly = true;
            this.dgvAllAlbums.RowHeadersVisible = false;
            this.dgvAllAlbums.RowHeadersWidth = 51;
            this.dgvAllAlbums.Size = new System.Drawing.Size(688, 281);
            this.dgvAllAlbums.TabIndex = 0;
            this.dgvAllAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllAlbums_CellClick);
            // 
            // columnAllSerie
            // 
            this.columnAllSerie.HeaderText = "Série";
            this.columnAllSerie.MinimumWidth = 6;
            this.columnAllSerie.Name = "columnAllSerie";
            this.columnAllSerie.ReadOnly = true;
            this.columnAllSerie.Width = 125;
            // 
            // ColumnNumSerie
            // 
            this.ColumnNumSerie.HeaderText = "N°";
            this.ColumnNumSerie.Name = "ColumnNumSerie";
            this.ColumnNumSerie.ReadOnly = true;
            this.ColumnNumSerie.Width = 30;
            // 
            // columnAllTitre
            // 
            this.columnAllTitre.HeaderText = "Titre";
            this.columnAllTitre.MinimumWidth = 6;
            this.columnAllTitre.Name = "columnAllTitre";
            this.columnAllTitre.ReadOnly = true;
            this.columnAllTitre.Width = 140;
            // 
            // columnAllScenariste
            // 
            this.columnAllScenariste.HeaderText = "Scénariste";
            this.columnAllScenariste.MinimumWidth = 6;
            this.columnAllScenariste.Name = "columnAllScenariste";
            this.columnAllScenariste.ReadOnly = true;
            this.columnAllScenariste.Width = 125;
            // 
            // columnAllDessinateur
            // 
            this.columnAllDessinateur.HeaderText = "Dessinateur";
            this.columnAllDessinateur.MinimumWidth = 6;
            this.columnAllDessinateur.Name = "columnAllDessinateur";
            this.columnAllDessinateur.ReadOnly = true;
            this.columnAllDessinateur.Width = 125;
            // 
            // columnMyAlbums
            // 
            this.columnMyAlbums.HeaderText = "Je l\'ai";
            this.columnMyAlbums.MinimumWidth = 6;
            this.columnMyAlbums.Name = "columnMyAlbums";
            this.columnMyAlbums.ReadOnly = true;
            this.columnMyAlbums.Width = 65;
            // 
            // columnWishlist
            // 
            this.columnWishlist.HeaderText = "Je le veux";
            this.columnWishlist.MinimumWidth = 6;
            this.columnWishlist.Name = "columnWishlist";
            this.columnWishlist.ReadOnly = true;
            this.columnWishlist.Width = 65;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Red;
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeconnexion.Location = new System.Drawing.Point(557, 12);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(112, 37);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnAjouterAlbum
            // 
            this.btnAjouterAlbum.Location = new System.Drawing.Point(410, 12);
            this.btnAjouterAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterAlbum.Name = "btnAjouterAlbum";
            this.btnAjouterAlbum.Size = new System.Drawing.Size(116, 37);
            this.btnAjouterAlbum.TabIndex = 2;
            this.btnAjouterAlbum.Text = "Ajouter un album";
            this.btnAjouterAlbum.UseVisualStyleBackColor = true;
            this.btnAjouterAlbum.Click += new System.EventHandler(this.btnAjouterAlbum_Click);
            // 
            // labelConsigne
            // 
            this.labelConsigne.AutoSize = true;
            this.labelConsigne.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelConsigne.Location = new System.Drawing.Point(24, 24);
            this.labelConsigne.Name = "labelConsigne";
            this.labelConsigne.Size = new System.Drawing.Size(289, 13);
            this.labelConsigne.TabIndex = 3;
            this.labelConsigne.Text = "Cliquez sur une case pour afficher les informations d\'une BD";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 411);
            this.Controls.Add(this.labelConsigne);
            this.Controls.Add(this.btnAjouterAlbum);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.tabCtrlAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BDThèque";
            this.tabCtrlAlbums.ResumeLayout(false);
            this.tabPageMyAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAlbums)).EndInit();
            this.tabWishlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlist)).EndInit();
            this.tabPageAllAlbums.ResumeLayout(false);
            this.tabPageAllAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlAlbums;
        private System.Windows.Forms.TabPage tabPageMyAlbums;
        private System.Windows.Forms.DataGridView dgvMyAlbums;
        private System.Windows.Forms.TabPage tabPageAllAlbums;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.DataGridView dgvAllAlbums;
        private System.Windows.Forms.Label labelPasDeResultat;
        private System.Windows.Forms.TabPage tabWishlist;
        private System.Windows.Forms.DataGridView dgvWishlist;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnAjouterAlbum;
        private System.Windows.Forms.Label labelConsigne;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMySerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyNumSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyDessinateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWishSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWishNumSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWishTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWishScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWishDessinateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllDessinateur;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnMyAlbums;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnWishlist;
    }
}