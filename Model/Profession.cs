using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Représente une profession exercé par un Usager
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class Profession
    {
        #region  --------- Attributs ---------
        private int idProfession;
        private string nomProfession;
        #endregion

        #region  --------- Propriétés ---------
        /// <summary>
        /// Renvoie ou modifie l'identifiant de la profession
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int IdProfession { get => idProfession; set => idProfession = value; }

        /// <summary>
        /// Renvoie ou modifie le nom de la profession
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string NomProfession { get => nomProfession; set => nomProfession = value; }
        #endregion

        #region --------- Constructeur & Destructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe
        /// </summary>
        /// <param name="nomProfession">le nom de la profession sous forme de chaîne de caractère</param>
        /// <param name="idProfession">identifiant de la profession sous forme d'entier</param>$
        /// <author>Lakhdar Gibril</author>
        public Profession(string nomProfession, int idProfession = 0)
        {
            this.idProfession = idProfession;
            this.nomProfession = nomProfession;
        }

        /// <summary>
        /// Destructeur naturel de la classe
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        ~Profession() { }
        #endregion

        #region --------- Méthodes ---------
        public override string ToString()
        {
            return nomProfession;
        }

        public override bool Equals(object? obj)
        {
            return obj is Profession profession &&
                   idProfession == profession.idProfession &&
                   nomProfession == profession.nomProfession;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idProfession, nomProfession);
        }
        #endregion
    }
}
