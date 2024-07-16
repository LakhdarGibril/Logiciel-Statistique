using Model;
using Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    /// <summary>
    /// Permet de tester les différentes méthodes de la couche Model
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class LogicLayerTest
    {
        [Fact]
        public void TestToString()
        {
            FakeUsagerDao fakeUsagerDao = new FakeUsagerDao();
            Usager usager = fakeUsagerDao.ObtenirUsager(1);
            Assert.Equal("Turing Alan", usager.ToString());

            Usager usager1 = fakeUsagerDao.ObtenirUsager(2);
            usager1.Prenom = "Alice"; /// On change juste le prénom pour éviter la condition d'ajout

            Famille famille = new Famille();
            famille.AjouterParent(usager);
            famille.AjouterParent(usager1);

            Assert.Equal("Turing Alan / Turing Alice", famille.ToString());
        }

        [Fact]
        public void TestEqual()
        {
            FakeUsagerDao fakeUsagerDao = new FakeUsagerDao();
            Usager usager = fakeUsagerDao.ObtenirUsager(1);
            Usager usager1 = fakeUsagerDao.ObtenirUsager(2);
            Assert.False(usager.Equals(usager1));

        }
    }
}
