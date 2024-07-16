using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Représente les ressources financières gagné par un usager
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class Ressources
    {
        #region --------- Attributs ---------
        private int idRessources;
        private string nomRessources;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Permet de renvoyer ou modifier l'identifiant de la ressource
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int IdRessources { get => idRessources; set => idRessources = value; }

        /// <summary>
        /// Permet de renvoyer ou modifier le nom de la ressource
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string NomRessources { get => nomRessources; set => nomRessources = value; }
        #endregion

        #region --------- Constructeur & Destructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Ressources() 
        {
            this.idRessources = 0;
            this.nomRessources = string.Empty;
        }

        /// <summary>
        /// Destructeur naturel de la classe
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        ~Ressources() { }
        #endregion

        #region --------- Méthodes ---------
        public override string ToString()
        {
            return this.nomRessources;
        }

        public override bool Equals(object? obj)
        {
            return obj is Ressources ressources &&
                   nomRessources == ressources.nomRessources;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nomRessources);
        }
        #endregion
    }
}
