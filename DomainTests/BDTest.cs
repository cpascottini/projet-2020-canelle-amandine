﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        BD bd = new BD(7, "titre", "auteur", "dessinateur", "éditeur", "série", 1, "genre", "catégorie", "couverture");

        [TestMethod()]
        public void DecrireTest()
        {
            string[] resultatAttendu = new string[] { "série", "1", "titre", "auteur", "dessinateur" };

            CollectionAssert.AreEquivalent(bd.Decrire(), resultatAttendu);
        }

        [TestMethod()]
        public void DecrireBDMarcheTest()
        {
            bool possedeValue = true;
            bool veutValue = false;
            string[] resultatAttendu = new string[] { "série", "1", "titre", "auteur", "dessinateur", "True", "False" };

            CollectionAssert.AreEquivalent(bd.DecrireBDMarche(possedeValue, veutValue), resultatAttendu);
        }
    }
}
