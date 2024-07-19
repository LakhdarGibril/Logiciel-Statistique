using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Interface servant à définir les méthodes pour le Dao relatifs aux Utilisateurs 
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public interface IUtilisateurDao
    {
        /// <summary>
        /// Méthode permettant d'obtenir un utilisateur à l'aide de son login
        /// </summary>
        /// <param name="login">le nom d'utilisateur saisit</param>
        /// <returns>un objet utilisateur pouvant être null</returns>
        Utilisateur? AvoirUtilisateur(string login);
    }
}
