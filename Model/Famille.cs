using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Représente une famille d'Usager avec des parents, des enfants...
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class Famille
    {
        #region --------- Attributs ---------
        private int numFamille;
        private List<Usager> usagers;
        private List<Enfant> enfants;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Permet de modifier ou récupérer l'identifiant de la famille
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int NumFamille { get => this.numFamille; set => this.numFamille = value; }

        /// <summary>
        /// Permet de récupérer la liste des parents de la famille.
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public List<Usager> Usagers { get => this.usagers; }

        /// <summary>
        /// Permet simplement de récupérer la liste des enfants de la famille
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public List<Enfant> Enfants { get => this.enfants; }
        #endregion

        #region --------- Constructeur & Destructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe Famille
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Famille()
        {
            this.numFamille = 0;
            this.usagers = new List<Usager>();
            this.enfants = new List<Enfant>();
        }

        /// <summary>
        /// Destructeur par défaut
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        ~Famille() { }
        #endregion

        #region --------- Méthodes ---------
        /// <summary>
        /// Méthode permettant d'ajouter un parent dans la famille
        /// </summary>
        /// <param name="usager">objet Usager à ajouter dans la liste</param>
        /// <author>Lakhdar Gibril</author>
        public void AjouterParent(Usager usager)
        {
            if (!this.usagers.Contains(usager)) this.usagers.Add(usager);
        }

        /// <summary>
        /// Méthode permettant de supprimer un parent dans la famille
        /// </summary>
        /// <param name="usager">un objet Usager à supprimer de la liste</param>
        /// <author>Lakhdar Gibril</author>
        public void SupprimerParent(Usager usager)
        {
            if (this.usagers.Contains(usager)) this.usagers.Remove(usager);
        }

        /// <summary>
        /// Méthode permettant d'ajouter un enfant dans la famille
        /// </summary>
        /// <param name="enfant">objet Enfant à ajouter dans la liste</param>
        /// <author>Lakhdar Gibril</author>
        public void AjouterEnfant(Enfant enfant)
        {
            if (!this.enfants.Contains(enfant)) this.enfants.Add(enfant);
        }

        /// <summary>
        /// Méthode permettant de supprimer un enfant dans la famille
        /// </summary>
        /// <param name="enfant">objet Enfant a supprimer de la liste</param>
        public void SupprimerEnfant(Enfant enfant)
        {
            if (this.enfants.Contains(enfant)) this.enfants.Remove(enfant);
        }

        public override string ToString()
        {
            string str = " ";
            if (this.usagers.Count == 2) str = $"{this.usagers[0].ToString()} / {this.usagers[1].ToString()}";
            else if (this.usagers.Count == 1) str = $"{this.usagers[0].ToString()}";
            return str;
        }

        public override bool Equals(object? obj)
        {
            return obj is Famille famille &&
                   EqualityComparer<List<Usager>>.Default.Equals(usagers, famille.usagers) &&
                   EqualityComparer<List<Enfant>>.Default.Equals(enfants, famille.enfants);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(usagers, enfants);
        }
        #endregion
    }
}
