using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Classe représentant un enfant appartenant à une famille, un prénom...
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class Enfant
    {
        #region --------- Attributs ---------
        private int idEnfant;
        private string nom;
        private string prenom;
        private int age;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Renvoie ou modifie l'identifiant de l'enfant
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int IdEnfant { get => idEnfant; set => idEnfant = value; }

        /// <summary>
        /// Renvoie ou modifie le nom de l'enfant
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Nom { get => nom; set => nom = value; }

        /// <summary>
        /// Renvoie ou modifie le prénom de l'enfant
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Prenom { get => prenom; set => prenom = value; }

        /// <summary>
        /// Renvoie ou modifie l'age de l'enfant
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int Age { get => age; set => age = value; }
        #endregion

        #region --------- Constructeur & Destructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe Enfant
        /// </summary>
        /// <param name="nom">nom de l'enfant sous forme de string</param>
        /// <param name="prenom">prenom de l'enfant sous forme de string</param>
        /// <param name="age">age de l'enfant sous forme d'entier</param>
        /// <param name="idEnfant">identifiant de l'enfant sous forme d'entier</param>
        /// <author>Lakhdar Gibril</author>
        public Enfant(string nom, string prenom, int age, int idEnfant = 0)
        {
            this.idEnfant = idEnfant;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        /// <summary>
        /// Destructeur de la classe Enfant
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        ~Enfant() { }
        #endregion

        #region --------- Méthodes ---------
        public override string ToString()
        {
            return $"{this.prenom} {this.nom} - {this.age} ans";
        }

        public override bool Equals(object? obj)
        {
            return obj is Enfant enfant &&
                   idEnfant == enfant.idEnfant &&
                   nom == enfant.nom &&
                   prenom == enfant.prenom &&
                   age == enfant.age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idEnfant, nom, prenom, age);
        }
        #endregion
    }
}
