using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class PersonneRepositoryTest
    {
        private PersonneRepository personneRepository;

        [TestInitialize()]
        public void Initialize()
        {
            RepositoryTest.InitDB();

            personneRepository = new PersonneRepository();
        }

        [TestMethod]
        public void TestPersRepo_GetAll()
        {
            var personnes = personneRepository.GetAll();
            // 3 personnes dans le jeu de données de test
            Assert.AreEqual(3, personnes.Count);
            var actual = personnes.Select(pers => pers.Login).ToList();
            var expected = new List<string> { "fanDeBD", "admin1", "roger" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void TestPersRepo_GetIdUtilisateur()
        {
            Assert.AreEqual(personneRepository.GetIdUtilisateur("roger", "vivelabd"), 3);
        }

        [TestMethod]
        public void TestPersRepo_GetRoleUtilisateur()
        {
            Assert.AreEqual(personneRepository.GetRoleUtilisateur(3), "utilisateur");
        }

        [TestMethod]
        public void TestLivreRepo_SaveUtilisateur()
        {
            personneRepository.SaveUtilisateur("testLogin","testMdp");

            RepositoryTest.ClearSession();
            // Recherche des personnes ayant le même login & mdp
            var personnes = personneRepository.GetAll().Where(p => p.Login ==
                "testLogin" && p.Mdp == "testMdp").ToList();
            
            // 1 seul utilisateur correspondant dans le jeu de données de test
            Assert.AreEqual(1, personnes.Count);
            Personne nouvelUtilisateur = personnes[0];
            Assert.AreEqual("testLogin", nouvelUtilisateur.Login);
            Assert.AreEqual("testMdp", nouvelUtilisateur.Mdp);
        }
    }
}
