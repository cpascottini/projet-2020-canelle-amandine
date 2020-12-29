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
            this.tabCtrlAlbums.SuspendLayout();
            this.tabPageMyAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAlbums)).BeginInit();
            this.tabPageAllAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlAlbums
            // 
            this.tabCtrlAlbums.Controls.Add(this.tabPageMyAlbums);
            this.tabCtrlAlbums.Controls.Add(this.tabPageAllAlbums);
            this.tabCtrlAlbums.Location = new System.Drawing.Point(10, 54);
            this.tabCtrlAlbums.Name = "tabCtrlAlbums";
            this.tabCtrlAlbums.SelectedIndex = 0;
            this.tabCtrlAlbums.Size = new System.Drawing.Size(639, 358);
            this.tabCtrlAlbums.TabIndex = 0;
            // 
            // tabPageMyAlbums
            // 
            this.tabPageMyAlbums.Controls.Add(this.dgvMyAlbums);
            this.tabPageMyAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageMyAlbums.Name = "tabPageMyAlbums";
            this.tabPageMyAlbums.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageMyAlbums.Size = new System.Drawing.Size(641, 332);
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
            this.dgvMyAlbums.Name = "dgvMyAlbums";
            this.dgvMyAlbums.RowHeadersWidth = 51;
            this.dgvMyAlbums.Size = new System.Drawing.Size(641, 336);
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
            this.tabPageAllAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllAlbums.Name = "tabPageAllAlbums";
            this.tabPageAllAlbums.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageAllAlbums.Size = new System.Drawing.Size(631, 332);
            this.tabPageAllAlbums.TabIndex = 1;
            this.tabPageAllAlbums.Text = "Tous les albums";
            this.tabPageAllAlbums.UseVisualStyleBackColor = true;
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
            this.btnRecherche.Location = new System.Drawing.Point(396, 17);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(33, 19);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(328, 20);
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
            this.dgvAllAlbums.Location = new System.Drawing.Point(1, 51);
            this.dgvAllAlbums.Name = "dgvAllAlbums";
            this.dgvAllAlbums.RowHeadersWidth = 51;
            this.dgvAllAlbums.Size = new System.Drawing.Size(634, 281);
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
            this.columnMyAlbums.Name = "columnMyAlbums";
            // 
            // columnWishlist
            // 
            this.columnWishlist.HeaderText = "Je la veux";
            this.columnWishlist.Name = "columnWishlist";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.tabCtrlAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "BDThèque";
            this.tabCtrlAlbums.ResumeLayout(false);
            this.tabPageMyAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAlbums)).EndInit();
            this.tabPageAllAlbums.ResumeLayout(false);
            this.tabPageAllAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAlbums)).EndInit();
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
    }
}