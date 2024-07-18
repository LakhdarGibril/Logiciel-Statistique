namespace Exceptions
{

    /// <summary>
    /// Une classe qui représente une exception lors de la connexion sur l'application pour un Utilisateur
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class ConnexionException : Exception
    {
        /// <summary>
        /// Constructeur par défaut de la classe ConnexionException, appelle le constructeur de la classe mère 
        /// </summary>
        /// <param name="message">message à afficher en cas d'exception</param>
        /// <author>Lakhdar Gibril</author>
        public ConnexionException(string message) : base(message) { }
    }
}
