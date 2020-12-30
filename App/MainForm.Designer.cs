namespace ProjetGL
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
            this.tabCtrlAlbums = new System.Windows.Forms.TabControl();
            this.tabPageMyAlbums = new System.Windows.Forms.TabPage();
            this.dgvMyAlbums = new System.Windows.Forms.DataGridView();
            this.columnMyTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyDessinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAllAlbums = new System.Windows.Forms.TabPage();
            this.labelPasDeResultat = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.dgvAllAlbums = new System.Windows.Forms.DataGridView();
            this.columnAllTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAllScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAllDessinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyAlbums = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnWishlist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabWishlist = new System.Windows.Forms.TabPage();
            this.dgvWishlist = new System.Windows.Forms.DataGridView();
            this.columnWishTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWishScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWishDessinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.tabCtrlAlbums.SuspendLayout();
            this.tabPageMyAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAlbums)).BeginInit();
            this.tabPageAllAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAlbums)).BeginInit();
            this.tabWishlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlist)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlAlbums
            // 
            this.tabCtrlAlbums.Controls.Add(this.tabPageMyAlbums);
            this.tabCtrlAlbums.Controls.Add(this.tabPageAllAlbums);
            this.tabCtrlAlbums.Controls.Add(this.tabWishlist);
            this.tabCtrlAlbums.Location = new System.Drawing.Point(13, 66);
            this.tabCtrlAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCtrlAlbums.Name = "tabCtrlAlbums";
            this.tabCtrlAlbums.SelectedIndex = 0;
            this.tabCtrlAlbums.Size = new System.Drawing.Size(930, 441);
            this.tabCtrlAlbums.TabIndex = 0;
            // 
            // tabPageMyAlbums
            // 
            this.tabPageMyAlbums.Controls.Add(this.dgvMyAlbums);
            this.tabPageMyAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabPageMyAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMyAlbums.Name = "tabPageMyAlbums";
            this.tabPageMyAlbums.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMyAlbums.Size = new System.Drawing.Size(922, 412);
            this.tabPageMyAlbums.TabIndex = 0;
            this.tabPageMyAlbums.Text = "Mes albums";
            this.tabPageMyAlbums.UseVisualStyleBackColor = true;
            // 
            // dgvMyAlbums
            // 
            this.dgvMyAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMyTitre,
            this.columnMyScenariste,
            this.columnMyDessinateur});
            this.dgvMyAlbums.Location = new System.Drawing.Point(0, 0);
            this.dgvMyAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMyAlbums.Name = "dgvMyAlbums";
            this.dgvMyAlbums.RowHeadersWidth = 51;
            this.dgvMyAlbums.Size = new System.Drawing.Size(922, 412);
            this.dgvMyAlbums.TabIndex = 0;
            this.dgvMyAlbums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyAlbums_CellContentClick);
            // 
            // columnMyTitre
            // 
            this.columnMyTitre.HeaderText = "Titre";
            this.columnMyTitre.MinimumWidth = 6;
            this.columnMyTitre.Name = "columnMyTitre";
            this.columnMyTitre.Width = 125;
            // 
            // columnMyScenariste
            // 
            this.columnMyScenariste.HeaderText = "Scénariste";
            this.columnMyScenariste.MinimumWidth = 6;
            this.columnMyScenariste.Name = "columnMyScenariste";
            this.columnMyScenariste.Width = 125;
            // 
            // columnMyDessinateur
            // 
            this.columnMyDessinateur.HeaderText = "Dessinateur";
            this.columnMyDessinateur.MinimumWidth = 6;
            this.columnMyDessinateur.Name = "columnMyDessinateur";
            this.columnMyDessinateur.Width = 125;
            // 
            // tabPageAllAlbums
            // 
            this.tabPageAllAlbums.Controls.Add(this.labelPasDeResultat);
            this.tabPageAllAlbums.Controls.Add(this.btnRecherche);
            this.tabPageAllAlbums.Controls.Add(this.tbRecherche);
            this.tabPageAllAlbums.Controls.Add(this.dgvAllAlbums);
            this.tabPageAllAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabPageAllAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAllAlbums.Name = "tabPageAllAlbums";
            this.tabPageAllAlbums.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAllAlbums.Size = new System.Drawing.Size(922, 412);
            this.tabPageAllAlbums.TabIndex = 1;
            this.tabPageAllAlbums.Text = "Tous les albums";
            this.tabPageAllAlbums.UseVisualStyleBackColor = true;
            // 
            // labelPasDeResultat
            // 
            this.labelPasDeResultat.AutoSize = true;
            this.labelPasDeResultat.BackColor = System.Drawing.Color.Transparent;
            this.labelPasDeResultat.Location = new System.Drawing.Point(243, 158);
            this.labelPasDeResultat.Name = "labelPasDeResultat";
            this.labelPasDeResultat.Size = new System.Drawing.Size(0, 17);
            this.labelPasDeResultat.TabIndex = 5;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(528, 21);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(100, 28);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(44, 23);
            this.tbRecherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(436, 22);
            this.tbRecherche.TabIndex = 2;
            // 
            // dgvAllAlbums
            // 
            this.dgvAllAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAllTitre,
            this.columnAllScenariste,
            this.columnAllDessinateur,
            this.columnMyAlbums,
            this.columnWishlist});
            this.dgvAllAlbums.Location = new System.Drawing.Point(1, 63);
            this.dgvAllAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAllAlbums.Name = "dgvAllAlbums";
            this.dgvAllAlbums.RowHeadersWidth = 51;
            this.dgvAllAlbums.Size = new System.Drawing.Size(921, 346);
            this.dgvAllAlbums.TabIndex = 0;
            this.dgvAllAlbums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllAlbums_CellContentClick);
            // 
            // columnAllTitre
            // 
            this.columnAllTitre.HeaderText = "Titre";
            this.columnAllTitre.MinimumWidth = 6;
            this.columnAllTitre.Name = "columnAllTitre";
            this.columnAllTitre.Width = 125;
            // 
            // columnAllScenariste
            // 
            this.columnAllScenariste.HeaderText = "Scénariste";
            this.columnAllScenariste.MinimumWidth = 6;
            this.columnAllScenariste.Name = "columnAllScenariste";
            this.columnAllScenariste.Width = 125;
            // 
            // columnAllDessinateur
            // 
            this.columnAllDessinateur.HeaderText = "Dessinateur";
            this.columnAllDessinateur.MinimumWidth = 6;
            this.columnAllDessinateur.Name = "columnAllDessinateur";
            this.columnAllDessinateur.Width = 125;
            // 
            // columnMyAlbums
            // 
            this.columnMyAlbums.HeaderText = "Je l\'ai";
            this.columnMyAlbums.MinimumWidth = 6;
            this.columnMyAlbums.Name = "columnMyAlbums";
            this.columnMyAlbums.Width = 125;
            // 
            // columnWishlist
            // 
            this.columnWishlist.HeaderText = "Je la veux";
            this.columnWishlist.MinimumWidth = 6;
            this.columnWishlist.Name = "columnWishlist";
            this.columnWishlist.Width = 125;
            // 
            // tabWishlist
            // 
            this.tabWishlist.Controls.Add(this.dgvWishlist);
            this.tabWishlist.Location = new System.Drawing.Point(4, 25);
            this.tabWishlist.Name = "tabWishlist";
            this.tabWishlist.Padding = new System.Windows.Forms.Padding(3);
            this.tabWishlist.Size = new System.Drawing.Size(922, 412);
            this.tabWishlist.TabIndex = 2;
            this.tabWishlist.Text = "Wishlist";
            this.tabWishlist.UseVisualStyleBackColor = true;
            // 
            // dgvWishlist
            // 
            this.dgvWishlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWishlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnWishTitre,
            this.columnWishScenariste,
            this.columnWishDessinateur});
            this.dgvWishlist.Location = new System.Drawing.Point(0, 0);
            this.dgvWishlist.Name = "dgvWishlist";
            this.dgvWishlist.RowHeadersWidth = 51;
            this.dgvWishlist.RowTemplate.Height = 24;
            this.dgvWishlist.Size = new System.Drawing.Size(919, 412);
            this.dgvWishlist.TabIndex = 0;
            this.dgvWishlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWishlist_CellContentClick);
            // 
            // columnWishTitre
            // 
            this.columnWishTitre.HeaderText = "Titre";
            this.columnWishTitre.MinimumWidth = 6;
            this.columnWishTitre.Name = "columnWishTitre";
            this.columnWishTitre.Width = 125;
            // 
            // columnWishScenariste
            // 
            this.columnWishScenariste.HeaderText = "Scénariste";
            this.columnWishScenariste.MinimumWidth = 6;
            this.columnWishScenariste.Name = "columnWishScenariste";
            this.columnWishScenariste.Width = 125;
            // 
            // columnWishDessinateur
            // 
            this.columnWishDessinateur.HeaderText = "Dessinateur";
            this.columnWishDessinateur.MinimumWidth = 6;
            this.columnWishDessinateur.Name = "columnWishDessinateur";
            this.columnWishDessinateur.Width = 125;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Red;
            this.btnDeconnexion.Location = new System.Drawing.Point(793, 12);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(150, 33);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 554);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.tabCtrlAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "BDThèque";
            this.tabCtrlAlbums.ResumeLayout(false);
            this.tabPageMyAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAlbums)).EndInit();
            this.tabPageAllAlbums.ResumeLayout(false);
            this.tabPageAllAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAlbums)).EndInit();
            this.tabWishlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlAlbums;
        private System.Windows.Forms.TabPage tabPageMyAlbums;
        private System.Windows.Forms.DataGridView dgvMyAlbums;
        private System.Windows.Forms.TabPage tabPageAllAlbums;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.DataGridView dgvAllAlbums;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyDessinateur;
        private System.Windows.Forms.Label labelPasDeResultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllDessinateur;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnMyAlbums;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnWishlist;
        private System.Windows.Forms.TabPage tabWishlist;
        private System.Windows.Forms.DataGridView dgvWishlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWishTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWishScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWishDessinateur;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}