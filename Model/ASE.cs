using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Classe représentant une ASE pour un Usager
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class ASE
    {
        #region  --------- Attributs ---------
        private int idASE;
        private string nomASE;
        #endregion

        #region  --------- Propriétés ---------
        /// <summary>
        /// Renvoie ou modifie l'identifiant de l'ASE
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int IdASE { get => idASE; set => idASE = value; }

        /// <summary>
        /// Renvoie ou modifie le nom de l'ASE d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string NomASE { get => nomASE; set => nomASE = value; }
        #endregion

        #region --------- Constructeur & Destructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe
        /// </summary>
        /// <param name="idASE">identifiant de l'ASE sous forme d'entier</param>
        /// <param name="nomASE">nom de l'ASE sous forme de chaîne de caractère</param>
        /// <author>Lakhdar Gibril</author>
        public ASE(string nomASE, int idASE = 0)
        {
            this.idASE = idASE;
            this.nomASE = nomASE;
        }

        /// <summary>
        /// Destructeur naturel de la classe
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        ~ASE() { }
        #endregion

        #region --------- Méthodes ---------
        public override string ToString()
        {
            return this.nomASE;
        }
        public override bool Equals(object? obj)
        {
            return obj is ASE aSE &&
                   nomASE == aSE.nomASE;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nomASE);
        }
        #endregion
    }
}
