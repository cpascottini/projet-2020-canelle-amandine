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
            this.tabPageAllAlbums = new System.Windows.Forms.TabPage();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.cbRecherche = new System.Windows.Forms.ComboBox();
            this.dgvAllAlbums = new System.Windows.Forms.DataGridView();
            this.columnMyTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMyDessinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAllTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAllScenariste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAllDessinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabCtrlAlbums.Location = new System.Drawing.Point(16, 55);
            this.tabCtrlAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCtrlAlbums.Name = "tabCtrlAlbums";
            this.tabCtrlAlbums.SelectedIndex = 0;
            this.tabCtrlAlbums.Size = new System.Drawing.Size(669, 420);
            this.tabCtrlAlbums.TabIndex = 0;
            // 
            // tabPageMyAlbums
            // 
            this.tabPageMyAlbums.Controls.Add(this.dgvMyAlbums);
            this.tabPageMyAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabPageMyAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMyAlbums.Name = "tabPageMyAlbums";
            this.tabPageMyAlbums.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMyAlbums.Size = new System.Drawing.Size(661, 391);
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
            this.dgvMyAlbums.Size = new System.Drawing.Size(661, 395);
            this.dgvMyAlbums.TabIndex = 0;
            // 
            // tabPageAllAlbums
            // 
            this.tabPageAllAlbums.Controls.Add(this.btnRecherche);
            this.tabPageAllAlbums.Controls.Add(this.tbRecherche);
            this.tabPageAllAlbums.Controls.Add(this.cbRecherche);
            this.tabPageAllAlbums.Controls.Add(this.dgvAllAlbums);
            this.tabPageAllAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabPageAllAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAllAlbums.Name = "tabPageAllAlbums";
            this.tabPageAllAlbums.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAllAlbums.Size = new System.Drawing.Size(661, 391);
            this.tabPageAllAlbums.TabIndex = 1;
            this.tabPageAllAlbums.Text = "Tous les albums";
            this.tabPageAllAlbums.UseVisualStyleBackColor = true;
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
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(191, 23);
            this.tbRecherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(328, 22);
            this.tbRecherche.TabIndex = 2;
            // 
            // cbRecherche
            // 
            this.cbRecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecherche.FormattingEnabled = true;
            this.cbRecherche.Items.AddRange(new object[] {
            "Nom",
            "Série",
            "Auteur",
            "Genre"});
            this.cbRecherche.Location = new System.Drawing.Point(21, 23);
            this.cbRecherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRecherche.Name = "cbRecherche";
            this.cbRecherche.Size = new System.Drawing.Size(160, 24);
            this.cbRecherche.TabIndex = 1;
            // 
            // dgvAllAlbums
            // 
            this.dgvAllAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAllTitre,
            this.columnAllScenariste,
            this.columnAllDessinateur});
            this.dgvAllAlbums.Location = new System.Drawing.Point(0, 74);
            this.dgvAllAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAllAlbums.Name = "dgvAllAlbums";
            this.dgvAllAlbums.RowHeadersWidth = 51;
            this.dgvAllAlbums.Size = new System.Drawing.Size(661, 317);
            this.dgvAllAlbums.TabIndex = 0;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 554);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlAlbums;
        private System.Windows.Forms.TabPage tabPageMyAlbums;
        private System.Windows.Forms.DataGridView dgvMyAlbums;
        private System.Windows.Forms.TabPage tabPageAllAlbums;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.ComboBox cbRecherche;
        private System.Windows.Forms.DataGridView dgvAllAlbums;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMyDessinateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllScenariste;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAllDessinateur;
    }
}