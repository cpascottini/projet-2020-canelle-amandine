﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace ProjetGL
{
    public partial class MainForm : Form
    {
        private IBDRepository bdRepository;
        public MainForm(IBDRepository bdRepository)
        {
            InitializeComponent();
            cbRecherche.SelectedIndex = 0;

            this.bdRepository = bdRepository;
            AfficherContenu();
        }

        private void AfficherContenu()
        {
            try
            {
                // BD du marché
                dgvAllAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des BD et remplissage du tableau
                foreach (BD bd in bdRepository.GetAll())
                {
                    dgvAllAlbums.Rows.Add(bd.Decrire());
                }
                DataGridViewCheckBoxColumn colonneCheckBox = new DataGridViewCheckBoxColumn();
                colonneCheckBox.HeaderText = "Je le veux";
                colonneCheckBox.Name = "checkBoxStatut";
                dgvAllAlbums.Columns.Add(colonneCheckBox);

                // tri alphabétique sur la 1ère colonne (nom)
                dgvAllAlbums.Sort(dgvAllAlbums.Columns[0], ListSortDirection.Ascending);


                // BD de l'utilisateur connecté
                dgvMyAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des BD et remplissage du tableau
                foreach (BD bd in bdRepository.GetBDUtilisateur())
                {
                    dgvMyAlbums.Rows.Add(bd.Decrire());
                }
                // tri alphabétique sur la 1ère colonne (nom)
                dgvMyAlbums.Sort(dgvMyAlbums.Columns[0], ListSortDirection.Ascending);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}