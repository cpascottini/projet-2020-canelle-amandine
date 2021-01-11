﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace DALTests
{
    [TestClass()]

    public class BDRepositoryTest
    {
        private BDRepository bdRepository;

        [TestInitialize()]
        public void Initialize()
        {
            RepositoryTest.InitDB();

            bdRepository = new BDRepository();
        }

        [TestMethod]
        public void TestBDRepo_GetAll()
        {
            var bds = bdRepository.GetAll();
            // 6 BD dans le jeu de données de test
            Assert.AreEqual(3, bds.Count);
            var actual = bds.Select(bd => bd.Titre).ToList();
            var expected = new List<string> { "Les bijoux de la Castafiore", "Ame rouge", "Astérix le Gaulois",
                "Persepolis-Tome 3", "Journal infime", "Mortebouse"};
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void TestBDRepo_GetBDRecherche()
        {
            var bds = bdRepository.GetBDRecherche("Julien");
            // 2 BD correspondant dans le jeu de données de test
            Assert.AreEqual(2, bds.Count);
            var actual = bds.Select(bd => bd.Titre).ToList();
            var expected = new List<string> {"Journal infime", "Mortebouse"};
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void TestLivreRepo_SaveBD()
        {
            bdRepository.SaveBD("testTitre", "testAuteur", "testDessinateur", "testEditeur",
                "testSerie", "testGenre", "testCouverture");

            RepositoryTest.ClearSession();
            // Recherche des BD ayant le même titre & auteur
            var bds = bdRepository.GetAll().Where(bd => bd.Titre ==
                "testTitre" && bd.Auteur == "testAuteur").ToList();

            // 1 seule BD correspondant dans le jeu de données de test
            Assert.AreEqual(1, bds.Count);
            BD nouvelleBD = bds[0];
            Assert.AreEqual("testTitre", nouvelleBD.Titre);
            Assert.AreEqual("testAuteur", nouvelleBD.Auteur);
        }
    }
}