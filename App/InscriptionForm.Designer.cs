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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(126, 119);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(192, 20);
            this.tbNewPassword.TabIndex = 4;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // tbNewLogin
            // 
            this.tbNewLogin.Location = new System.Drawing.Point(114, 32);
            this.tbNewLogin.Name = "tbNewLogin";
            this.tbNewLogin.Size = new System.Drawing.Size(192, 20);
            this.tbNewLogin.TabIndex = 3;
            // 
            // btnInscriptionAnnuler
            // 
            this.btnInscriptionAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInscriptionAnnuler.Location = new System.Drawing.Point(49, 132);
            this.btnInscriptionAnnuler.Name = "btnInscriptionAnnuler";
            this.btnInscriptionAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnInscriptionAnnuler.TabIndex = 6;
            this.btnInscriptionAnnuler.Text = "Annuler";
            this.btnInscriptionAnnuler.UseVisualStyleBackColor = true;
            this.btnInscriptionAnnuler.Click += new System.EventHandler(this.btnInscriptionAnnuler_Click);
            // 
            // btnInscriptionConfirmer
            // 
            this.btnInscriptionConfirmer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInscriptionConfirmer.Location = new System.Drawing.Point(193, 132);
            this.btnInscriptionConfirmer.Name = "btnInscriptionConfirmer";
            this.btnInscriptionConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnInscriptionConfirmer.TabIndex = 7;
            this.btnInscriptionConfirmer.Text = "Confirmer";
            this.btnInscriptionConfirmer.UseVisualStyleBackColor = true;
            this.btnInscriptionConfirmer.Click += new System.EventHandler(this.btnInscriptionConfirmer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInscriptionAnnuler);
            this.groupBox1.Controls.Add(this.tbNewLogin);
            this.groupBox1.Controls.Add(this.btnInscriptionConfirmer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 171);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Veuillez choisir vos identifiants de connexion";
            // 
            // InscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 226);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "InscriptionForm";
            this.Text = "Inscription à la BDthèque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}