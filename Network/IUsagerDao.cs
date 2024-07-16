using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Représente une interface pour un Dao d'usager
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public interface IUsagerDao
    {
        /// <summary>
        /// Permet d'obtenir un usager par son identifiant
        /// </summary>
        /// <param name="id">identifiant de l'usager à récupérer</param>
        /// <returns>un objet Usager</returns>
        Usager ObtenirUsager(int id);

        /// <summary>
        /// Permet d'obtenir tout les usagers 
        /// </summary>
        /// <returns>un objet List d'Usager</returns>
        List<Usager> ObtenirToutUsager();
    }
}
