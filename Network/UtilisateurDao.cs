using Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Classe permettant d'obtenir les données relatives aux utilisateurs
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class UtilisateurDao : IUtilisateurDao
    {
        #region --------- Attributs ---------
        private Database _database;
        #endregion

        #region --------- Constructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public UtilisateurDao() 
        {
            this._database = new Database();
        }
        #endregion

        #region --------- Méthode ---------
        public Utilisateur? AvoirUtilisateur(string login)
        {
            Utilisateur? utilisateur = null;
            using (SQLiteConnection connection = this._database.Connection)
            {
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Utilisateur WHERE NomUtilisateur = @login";
                    command.Parameters.Add(new SQLiteParameter("@login", login));
                    command.ExecuteNonQuery();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            utilisateur = new Utilisateur(reader.GetString(1),reader.GetInt32(0));
                        }
                    }
                }
            }
            this._database.Connection.Close();
            return utilisateur;
        }
        #endregion
    }
}
