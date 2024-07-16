using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Représente une durée de séjour pour un Usager au sein de l'association.
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class Sejour
    {
        #region  --------- Attributs ---------
        private DateTime debut;
        private DateTime fin;
        private int nbJours;
        private int nbMois;
        private string dureeHebergement;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Permet de récupérer ou modifier la date de début du séjour
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public DateTime Debut { get => debut; set => debut = value; }

        /// <summary>
        /// Permet de récupérer ou de modifier la date de fin du séjour
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public DateTime Fin { get => fin; set => fin = value; }

        /// <summary>
        /// Permet de récupérer ou modifier la durée en nombre de jour 
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int NbJours { get => nbJours; set => nbJours = value; }

        /// <summary>
        /// Permet de récupérer ou modifier la durée en nombre de mois
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int NbMois { get => nbMois; set => nbMois = value; }

        /// <summary>
        /// Permet de récupérer ou modifier la durée de l'hebergement
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string DureeHebergement { get => dureeHebergement; set => dureeHebergement = value; }
        #endregion

        #region --------- Constructeur & Destructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Sejour() 
        {
            this.nbJours = 0;
            this.nbMois = 0;
            this.dureeHebergement = string.Empty;
        }

        /// <summary>
        /// Destructeur naturel de la classe
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        ~Sejour() { }
        #endregion

        #region  --------- Méthodes ---------
        public override string ToString()
        {
            return $"{this.debut} - {this.fin}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Sejour sejour &&
                   debut == sejour.debut &&
                   fin == sejour.fin;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(debut, fin);
        }
        #endregion
    }
}
