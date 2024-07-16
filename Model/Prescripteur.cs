using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Représente un prescripteur pour un Usager
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class Prescripteur
    {
        #region --------- Attributs ---------
        private int idPrescripteur;
        private string nomPrescripteur;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Renvoie ou modifie l'identifiant d'un prescripteur 
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int IdPrescripteur { get => idPrescripteur; set => idPrescripteur = value; }

        /// <summary>
        /// Renvoie ou modifie le nom d'un prescripteur
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string NomPrescripteur { get => nomPrescripteur; set => nomPrescripteur = value; }
        #endregion

        #region  --------- Constructeur & Destructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe
        /// </summary>
        /// <param name="nomPrescripteur">le nom du prescripteur sous forme de chaîne de caractère</param>
        /// <param name="idPrescripteur">l'identifiant du prescripteur valant 0 par défaut</param>
        /// <author>Lakhdar Gibril</author>
        public Prescripteur(string nomPrescripteur, int idPrescripteur = 0)
        {
            this.idPrescripteur = idPrescripteur;
            this.nomPrescripteur = nomPrescripteur;
        }

        /// <summary>
        /// Destructeur naturel de la base
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        ~Prescripteur() { }
        #endregion

        #region  --------- Méthodes ---------
        public override string ToString()
        {
            return nomPrescripteur;
        }

        public override bool Equals(object? obj)
        {
            return obj is Prescripteur prescripteur &&
                   nomPrescripteur == prescripteur.nomPrescripteur;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nomPrescripteur);
        }
        #endregion
    }
}
