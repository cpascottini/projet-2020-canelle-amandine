namespace ProjetGL
{
    partial class InscriptionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbNewLogin = new System.Windows.Forms.TextBox();
            this.btnInscriptionAnnuler = new System.Windows.Forms.Button();
            this.btnInscriptionConfirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(195, 158);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(255, 22);
            this.tbNewPassword.TabIndex = 4;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // tbNewLogin
            // 
            this.tbNewLogin.Location = new System.Drawing.Point(195, 92);
            this.tbNewLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewLogin.Name = "tbNewLogin";
            this.tbNewLogin.Size = new System.Drawing.Size(255, 22);
            this.tbNewLogin.TabIndex = 3;
            // 
            // btnInscriptionAnnuler
            // 
            this.btnInscriptionAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInscriptionAnnuler.Location = new System.Drawing.Point(105, 306);
            this.btnInscriptionAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnInscriptionAnnuler.Name = "btnInscriptionAnnuler";
            this.btnInscriptionAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnInscriptionAnnuler.TabIndex = 6;
            this.btnInscriptionAnnuler.Text = "Annuler";
            this.btnInscriptionAnnuler.UseVisualStyleBackColor = true;
            this.btnInscriptionAnnuler.Click += new System.EventHandler(this.btnInscriptionAnnuler_Click);
            // 
            // btnInscriptionConfirmer
            // 
            this.btnInscriptionConfirmer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInscriptionConfirmer.Location = new System.Drawing.Point(303, 306);
            this.btnInscriptionConfirmer.Margin = new System.Windows.Forms.Padding(4);
            this.btnInscriptionConfirmer.Name = "btnInscriptionConfirmer";
            this.btnInscriptionConfirmer.Size = new System.Drawing.Size(100, 28);
            this.btnInscriptionConfirmer.TabIndex = 7;
            this.btnInscriptionConfirmer.Text = "Confirmer";
            this.btnInscriptionConfirmer.UseVisualStyleBackColor = true;
            this.btnInscriptionConfirmer.Click += new System.EventHandler(this.btnInscriptionConfirmer_Click);
            // 
            // InscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 378);
            this.Controls.Add(this.btnInscriptionConfirmer);
            this.Controls.Add(this.btnInscriptionAnnuler);
            this.Controls.Add(this.tbNewLogin);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InscriptionForm";
            this.Text = "Inscription à la BDthèque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbNewLogin;
        private System.Windows.Forms.Button btnInscriptionAnnuler;
        private System.Windows.Forms.Button btnInscriptionConfirmer;
    }
}