using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DomainTests
{
    [TestClass()]
    public class BDTest
    {
        BD bd = new BD(5, "titre", "auteur", "dessinateur", "éditeur", "série", "genre", "couverture");

        [TestMethod()]
        public void DecrireTest()
        {
            string[] resultatAttendu = new string[] { "titre", "auteur", "dessinateur" };

            for (int i=0; i<bd.Decrire().Length; i++)
            {
                Assert.AreEqual(bd.Decrire()[i], resultatAttendu[i]);    // compare la valeur attendue à la valeur réelle
            }
            // si on ne fait pas le for, le Assert compare les adresses des tableaux et renvoie un échec du test
        }

        [TestMethod()]
        public void DecrireBDMarcheTest()
        {
            bool possedeValue = true;
            bool veutValue = false;
            string[] resultatAttendu = new string[] { "titre", "auteur", "dessinateur", "True", "False" };

            for (int i = 0; i < bd.DecrireBDMarche(possedeValue, veutValue).Length; i++)
            {
                Assert.AreEqual(bd.DecrireBDMarche(possedeValue, veutValue)[i], resultatAttendu[i]);    // compare la valeur attendue à la valeur réelle
            }
        }
    }
}
