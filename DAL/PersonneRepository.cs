﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class PersonneRepository : Repository, IPersonneRepository
    {
        public IList<Personne> GetAll()
        {
            return Session.Query<Personne>().ToList();
        }
        public int GetIdUtilisateur(string loginLocal, string mdpLocal)
        {
            string requete = "select IdPersonne from Personne p where p.Login='" + loginLocal + "' and p.Mdp='" + mdpLocal + "'";
            int idUtilisateur = (int)Session.CreateQuery(requete).UniqueResult<int>();

            return idUtilisateur;
        }
        public string GetRoleUtilisateur(int idUtilisateurLocal)
        {
            return Session.CreateQuery("select Role from Personne p where p.IdPersonne = :util").SetInt32("util", idUtilisateurLocal).UniqueResult<string>();
        }
        public void SaveUtilisateur(string loginLocal, string mdpLocal)
        {

            Personne nouvelUtilisateur = new Personne();

            nouvelUtilisateur.Login = loginLocal;
            nouvelUtilisateur.Mdp = mdpLocal;
            nouvelUtilisateur.Role = "utilisateur"; // on ne peut pas s'inscrire avec le statut d'admin

            Session.SaveOrUpdate(nouvelUtilisateur); // Ajout d’une ligne dans la table Personne de la DB
            Session.Flush();
        }
    }
}
