﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App;
using DAL;
using Domain;

namespace ProjetGL
{
    public partial class MainForm : Form
    {
        private IBDRepository bdRepository;
        private IRelationRepository relationRepository;
        private IPersonneRepository personneRepository;
        private int idUtilisateur;
        private bool hasTbRechercheBeenEdited = false;
        private IList<BD> BDUtilisateur ;
        private IList<BD> BDWishlist;


        public MainForm(IBDRepository bdRepository, IRelationRepository relationRepository, IPersonneRepository personneRepository, int idUtilisateur)
        {
            InitializeComponent();

            this.bdRepository = bdRepository;
            this.relationRepository = relationRepository;
            this.personneRepository = personneRepository;
            this.idUtilisateur = idUtilisateur;
            MajBDUtilisateur();


            string roleUtilisateur = personneRepository.GetRoleUtilisateur(idUtilisateur);
            // si la personne connectée n'est pas un admin elle ne peut pas ajouter d'album au marché
            if (roleUtilisateur!="administrateur")
            {
                btnAjouterAlbum.Visible = false;
            }
            AfficherContenu();
        }

        private void MajBDUtilisateur()
        {
            BDUtilisateur = bdRepository.GetBDUtilisateur(idUtilisateur, "possede");
            BDWishlist = bdRepository.GetBDUtilisateur(idUtilisateur, "veut");
        }

        private void AfficherContenu()
        {
            try
            {
                // BD que possède l'utilisateur connecté
                AfficherBDUtilisateur(dgvMyAlbums, BDUtilisateur);

                // BD que veut l'utilisateur connecté              
                AfficherBDUtilisateur(dgvWishlist, BDWishlist);
                
                // BD du marché
                AfficherBDMarche(bdRepository.GetAll());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherBDMarche(IList<BD> listeBD)
        {
            dgvAllAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes                                     

            List<BD> listeBDTri = TrierBD(listeBD); // tri des bd
                       
            foreach (BD bd in listeBDTri) // Accès à la liste des BD et remplissage du tableau
            {
                bool possede = BDUtilisateur.Contains(bd);
                bool veut = BDWishlist.Contains(bd);
                dgvAllAlbums.Rows.Add(bd.DecrireBDMarche(possede, veut));
            }          
        }

        private List<BD> TrierBD(IList<BD> listeBD)
        {
            List<BD> listeBDTri = new List<BD>();
            foreach (BD bd in listeBD)
            {
                listeBDTri.Add(bd);
            }
            listeBDTri.Sort(Compare);
            return listeBDTri;
        }

        private int Compare(BD bd1, BD bd2) // utilisée pour le tri des bd
        {
            if (bd1.Serie != null && bd2.Serie != null)
            {
                if (bd1.Serie != bd2.Serie)
                {
                    return bd1.Serie.CompareTo(bd2.Serie);
                }
                else
                {
                    return bd1.NumSerie.CompareTo(bd2.NumSerie);
                }
            }
            else
            {
                if (bd1.Serie == null && bd2.Serie == null)
                {
                    return bd1.Titre.CompareTo(bd2.Titre);
                }
                else
                {
                    if (bd1.Serie == null)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        private void AfficherBDUtilisateur(DataGridView dgv, IList<BD> listeBD)
        {
            dgv.Rows.Clear();  // suppression des éventuelles lignes existantes

            List<BD> listeBDTri = TrierBD(listeBD); // tri des BD

            foreach (BD bd in listeBDTri) // Accès à la liste des BD et remplissage du tableau
            {
                dgv.Rows.Add(bd.Decrire());
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {           
            string recherche = tbRecherche.Text;

            // on réaffiche le dgv si une recherche précédente l'a caché
            dgvAllAlbums.Show();

            // on remasque le label si une recherche précédente l'a affichée
            labelPasDeResultat.Visible = false;

            dgvAllAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
            IList<BD> BDRecherche = bdRepository.GetBDRecherche(recherche);
            if (BDRecherche.Count() != 0)
            {
                AfficherBDMarche(BDRecherche);
            }
            else // s'il n'y a pas de résultat
            {
                dgvAllAlbums.Hide();

                labelPasDeResultat.Visible = true;
                labelPasDeResultat.Text = "Aucun résultat pour cette recherche.";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            // pour rechercher en appuyant sur entrée
        {
            if (keyData == (Keys.Enter))
            {
                btnRecherche.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // on réaffiche le dgv si une recherche précédente l'a caché
            dgvAllAlbums.Show();

            // on remasque le label si une recherche précédente l'a affichée
            labelPasDeResultat.Visible = false;

            tbRecherche.Text = "";
            AfficherBDMarche(bdRepository.GetAll());
        }

        private void dgvAllAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;           
            if(rowIndex!=-1)
            {
                DataGridViewRow row = this.dgvAllAlbums.Rows[rowIndex];
                string titre = row.Cells["columnAllTitre"].Value.ToString();
                string auteur = row.Cells["columnAllScenariste"].Value.ToString();
                IList<BD> bdRow = bdRepository.GetBDRow(titre, auteur);
                BD bd = bdRow[0];
                DataGridViewCheckBoxCell caseAjoutWishlist = (DataGridViewCheckBoxCell)dgvAllAlbums.Rows[rowIndex].Cells["columnWishlist"];
                DataGridViewCheckBoxCell caseAjoutPossession = (DataGridViewCheckBoxCell)dgvAllAlbums.Rows[rowIndex].Cells["columnMyAlbums"];

                bool showAlbum = true;

                // ajout d'une BD du marché à sa liste d'envies                   
                if (caseAjoutWishlist.Selected && !Convert.ToBoolean(caseAjoutWishlist.Value))
                {
                    showAlbum = false;
                    AjouterBDWishlist(bd);
                }

                // ajout d'une BD du marché à ses possessions   
                if (caseAjoutPossession.Selected && !Convert.ToBoolean(caseAjoutPossession.Value))
                {
                    showAlbum = false;
                    AjouterBDPossession(bd, caseAjoutWishlist);                  
                }

                // suppression d'une BD de sa wishlist
                if (caseAjoutWishlist.Selected && Convert.ToBoolean(caseAjoutWishlist.Value))
                {
                    showAlbum = false;
                    SupprimerBD(bd, "veut", "wishlist");
                }


                // suppression d'une BD de ses possessions
                if (caseAjoutPossession.Selected && Convert.ToBoolean(caseAjoutPossession.Value))
                {
                    showAlbum = false;
                    SupprimerBD(bd, "possede", "BDThèque");
                }

                // on n'affiche la description d'un album que si le clic n'a pas lieu sur une colonne à cocher
                if (showAlbum == true)
                {
                    AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
                    albumForm.ShowDialog();

                }
                else
                {
                    MajBDUtilisateur();
                    AfficherContenu(); // on réaffiche le contenu pour mettre les données à jour
                }
            }           
        }

        private void AjouterBDWishlist(BD bd)
        {
            if (BDUtilisateur.Contains(bd))
            // si la BD est déjà dans les possessions de l'utilisateur
            {
                string message = String.Format("Vous possédez déjà l'album '{0}'.", bd.Titre);
                MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ajouter la BD du row à la liste d'envies
                relationRepository.SaveRelation(bd, idUtilisateur, "veut");
                string message = String.Format("L'album '{0}' a bien été ajouté à votre wishlist.", bd.Titre);
                MessageBox.Show(message, "Ajout à la wishlist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void AjouterBDPossession(BD bd, DataGridViewCheckBoxCell caseAjoutWishlist)
        {
            if (Convert.ToBoolean(caseAjoutWishlist.Value))    // si la BD était dans la liste d'envie on l'enlève
            {
                // ajouter la BD du row à la liste des possessions et la supprimer de la wishlist
                relationRepository.UpdateRelation(bd, idUtilisateur);
                string message = String.Format("L'album '{0}' a bien été ajouté à votre BDthèque et supprimé de votre wishlist.", bd.Titre);
                MessageBox.Show(message, "Ajout à la BDthèque", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                caseAjoutWishlist.Value = false;
            }
            else
            {
                // ajouter la BD du row à la liste des possessions
                relationRepository.SaveRelation(bd, idUtilisateur, "possede");
                string message = String.Format("L'album '{0}' a bien été ajouté à votre BDthèque.", bd.Titre);
                MessageBox.Show(message, "Ajout à la BDthèque", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void SupprimerBD(BD bd, string statut, string ensemble)
        {
            relationRepository.DeleteRelation(bd, idUtilisateur, statut);
            string message = String.Format("L'album '{0}' a bien été retiré de votre {1}.", bd.Titre, ensemble);
            MessageBox.Show(message, "Retrait d'un album de la "+ensemble, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dgvWishlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex!=-1)
            {
                AfficherAlbum(rowIndex, dgvWishlist, "columnWishTitre", "columnWishScenariste");
            }           
        }
        private void dgvMyAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex!=-1)
            {
                AfficherAlbum(rowIndex, dgvMyAlbums, "columnMyTitre", "columnMyScenariste");
            }           
        }

        private void AfficherAlbum(int rowIndex, DataGridView dgv, string columnTitre, string columnAuteur)
        {
            DataGridViewRow row = dgv.Rows[rowIndex];
            string titre = row.Cells[columnTitre].Value.ToString();
            string auteur = row.Cells[columnAuteur].Value.ToString();

            AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
            albumForm.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {            
            this.Close();    
        }

        private void btnAjouterAlbum_Click(object sender, EventArgs e)
        {
            AjoutAlbumForm ajoutAlbumForm = new AjoutAlbumForm(bdRepository);
            ajoutAlbumForm.ShowDialog();
            AfficherBDMarche(bdRepository.GetAll());
        }

        private void tbRecherche_Enter(object sender, EventArgs e)
        {
            if(!hasTbRechercheBeenEdited)
            {
                tbRecherche.Text = "";
                tbRecherche.ForeColor = Color.Black;
                hasTbRechercheBeenEdited = true;
            }          
        }
    }
}
