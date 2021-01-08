namespace ProjetGL
{
    partial class DeconnexionForm
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
            this.labelInfoDeconnexion = new System.Windows.Forms.Label();
            this.labelQuestionDeconnexion = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfoDeconnexion
            // 
            this.labelInfoDeconnexion.AutoSize = true;
            this.labelInfoDeconnexion.Location = new System.Drawing.Point(61, 41);
            this.labelInfoDeconnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoDeconnexion.Name = "labelInfoDeconnexion";
            this.labelInfoDeconnexion.Size = new System.Drawing.Size(286, 17);
            this.labelInfoDeconnexion.TabIndex = 0;
            this.labelInfoDeconnexion.Text = "Vous allez être déconnecté de la BDthèque.";
            // 
            // labelQuestionDeconnexion
            // 
            this.labelQuestionDeconnexion.AutoSize = true;
            this.labelQuestionDeconnexion.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelQuestionDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionDeconnexion.Location = new System.Drawing.Point(13, 89);
            this.labelQuestionDeconnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionDeconnexion.Name = "labelQuestionDeconnexion";
            this.labelQuestionDeconnexion.Size = new System.Drawing.Size(529, 20);
            this.labelQuestionDeconnexion.TabIndex = 1;
            this.labelQuestionDeconnexion.Text = "Voulez-vous quitter l\'application ou vous reconnecter à la BDthèque ?\r\n";
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnQuit.Location = new System.Drawing.Point(49, 198);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 28);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinue.Location = new System.Drawing.Point(236, 198);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(117, 28);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Me reconnecter";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // DeconnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 271);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.labelQuestionDeconnexion);
            this.Controls.Add(this.labelInfoDeconnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeconnexionForm";
            this.Text = "Déconnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoDeconnexion;
        private System.Windows.Forms.Label labelQuestionDeconnexion;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnContinue;
    }
}