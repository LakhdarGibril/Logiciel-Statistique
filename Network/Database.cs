using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Classe qui représente une base de données en SQLite
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class Database
    {
        #region --------- Attributs ---------
        private SQLiteConnection connection;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Propriété en lecture seule ne permettant d'obtenir que l'attribut SQLiteConnection
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public SQLiteConnection Connection => this.connection;
        #endregion

        #region --------- Constructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe ne servant qu'à initialiser l'accès à la base de données
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Database() 
        {
            this.connection = new SQLiteConnection("Data Source=database.db");
        }
        #endregion
    }
}
