
namespace Model
{
    /// <summary>
    /// Classe représentant un utilisateur avec un login, un mot de passe
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class Utilisateur
    {
        #region --------- Attributs ---------
        private int idUtilisateur;
        private string nomUtilisateur;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Renvoie ou modifie l'identifiant de l'utilisateur
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; }

        /// <summary>
        /// Renvoie ou modifie le nom d'utilisateur
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        #endregion

        #region --------- Constructeur & Destructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe Utilisateur
        /// </summary>
        /// <param name="nomUtilisateur">le nom d'utilisateur saisie (chaîne de caractère)</param>
        /// <param name="motDePasse">le mot de passe saisie (chaîne de caractère)</param>
        /// <param name="idUtilisateur">identifiant de l'utilisateur</param>
        /// <author>Lakhdar Gibril</author>
        public Utilisateur(string nomUtilisateur, int idUtilisateur = 0)
        {
            this.idUtilisateur = idUtilisateur;
            this.nomUtilisateur = nomUtilisateur;
        }

        /// <summary>
        /// Destructeur naturel de la classe Utilisateur
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        ~Utilisateur() { }
        #endregion

        #region --------- Méthodes ---------
        public override string ToString()
        {
            return this.nomUtilisateur;
        }

        public override bool Equals(object? obj)
        {
            return obj is Utilisateur utilisateur &&
                   nomUtilisateur == utilisateur.nomUtilisateur;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nomUtilisateur);
        }
        #endregion
    }
}
