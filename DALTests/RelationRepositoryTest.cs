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
    public class RelationRepositoryTest
    {
        private RelationRepository relationRepository;
        private BDRepository bdRepository;

        [TestInitialize()]
        public void Initialize()
        {
            RepositoryTest.InitDB();

            relationRepository = new RelationRepository();
            bdRepository = new BDRepository();
        }

        [TestMethod]
        public void TestRelationRepo_GetAll()
        {
            var relations = relationRepository.GetAll();
            // 5 relations dans le jeu de données de test
            Assert.AreEqual(5, relations.Count);
            var actual = relations.Select(r => r.Statut).ToList();
            var expected = new List<string> { "possede", "veut", "possede", "possede", "veut"};
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void TestRelationRepo_SaveRelation()
        {
            var bd = bdRepository.GetAll()[2]; // BD n°3
            relationRepository.SaveRelation(bd,1,"veut");

            RepositoryTest.ClearSession();
            // Recherche des relations ayant le même IdPersonne & IdBD
            var relations = relationRepository.GetAll().Where(r => r.PersonneRelation ==
                1 && r.BDRelation == 3).ToList();

            // 1 seule BD correspondant dans le jeu de données de test
            Assert.AreEqual(1, relations.Count);
            Relation nouvelleRelation = relations[0];
            Assert.AreEqual(1, nouvelleRelation.PersonneRelation);
            Assert.AreEqual(3, nouvelleRelation.BDRelation);
        }

        //UpdateRelation
        //DeleteRelation

        [TestMethod]
        public void TestRelationRepo_GetIdBD()
        {
            Assert.AreEqual(2, relationRepository.GetIdBD("Ame rouge", "Juan Diaz Canales"));
        }

        [TestMethod]
        public void TestRelationRepo_GetIdRelation()
        {
            Assert.AreEqual(4, relationRepository.GetIdRelation(3,4,"possede"));
        }
    }
}
