using Model;

namespace Network
{
    /// <summary>
    /// Représente un Dao factice pour les usagers
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class FakeUsagerDao : IUsagerDao
    {
        #region 
        public Usager ObtenirUsager(int id)
        {
            Usager usager = new Usager() {
                IdUsager = id,
                Nom = "Turing",
                Prenom = "Alan",
                Genre = "Homme",
                DateNaissance = new DateTime(1912, 06, 23),
                CompositionFamiliale = "En couple",
                MotifAdmission = "Réalisation d'application",
                DispositifSortant = "Autres"
            };
            return usager;
        }

        public List<Usager> ObtenirToutUsager()
        {
            List<Usager> usagers = new List<Usager>();

            Usager usager = new Usager()
            {
                IdUsager = 0,
                Nom = "Turing",
                Prenom = "Alan",
                Genre = "Homme",
                DateNaissance = new DateTime(1912, 06, 23),
                CompositionFamiliale = "En couple",
                MotifAdmission = "Réalisation d'application",
                DispositifSortant = "Autres"
            };

            Usager usager2 = new Usager()
            {
                IdUsager = 1,
                Nom = "Zuckerberg",
                Prenom = "Mark",
                Genre = "Homme",
                DateNaissance = new DateTime(1984, 05, 14),
                CompositionFamiliale = "En couple",
                MotifAdmission = "Optimiser CEGI",
                DispositifSortant = "Autres"
            };

            Usager usager3 = new Usager() 
            {
                IdUsager = 2,
                Nom = "Lakhdar",
                Prenom = "Gibril",
                Genre = "Homme",
                DateNaissance = new DateTime(2003,10,06),
                CompositionFamiliale = "Célibataire",
                MotifAdmission = "Réaliser une application statistiques",
                DispositifSortant = "Autres"
            };

            Usager usager4 = new Usager()
            {
                IdUsager = 3,
                Nom = "Floyd",
                Prenom = "Sally",
                Genre = "Femme",
                DateNaissance = new DateTime(1950, 05, 20),
                CompositionFamiliale = "En couple",
                MotifAdmission = "Cours d'informatique pour les jeunes",
                DispositifSortant = "Autres"
            };

            usagers.Add(usager);
            usagers.Add(usager2);
            usagers.Add(usager3);
            usagers.Add(usager4);

            return usagers;
        }
        #endregion
    }
}
