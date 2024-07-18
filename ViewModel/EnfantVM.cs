using Model;
using System.ComponentModel;

namespace ViewModel
{
    /// <summary>
    /// Représente une vue model pour la classe Enfant
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class EnfantVM : BaseVM
    {
        #region --------- Attributs ---------
        private Enfant model;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Permet de retourner le model d'Enfant de la vue model
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Enfant Model => this.model;

        /// <summary>
        /// Propriété en lecture seule retournant l'identifiant de l'enfant.
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int IdEnfant => this.model.IdEnfant;

        /// <summary>
        /// Propriété permettant de modifier ou renvoyer le nom de l'enfant.
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Nom
        {
            get => this.model.Nom;
            set
            {
                this.model.Nom = value;
                this.NotifyPropertyChanged("Nom");
            }
        }

        /// <summary>
        /// Propriété permettant de modifier ou renvoyer le prénom de l'enfant.
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Prenom
        {
            get => this.model.Prenom;
            set
            {
                this.model.Prenom = value;
                this.NotifyPropertyChanged("Prenom");
            }
        }

        /// <summary>
        /// Propriété permettant de modifier ou renvoyer l'âge de l'enfant.
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int Age
        {
            get => this.model.Age;
            set
            {
                this.model.Age = value;
                this.NotifyPropertyChanged("Age");
            }
        }
        #endregion

        #region --------- Constructeur ---------
        /// <summary>
        /// Constructeur naturel de la classe EnfantVM
        /// </summary>
        /// <param name="model">objet Enfant servant de modèle pour la vue model</param>
        /// <author>Lakhdar Gibril</author>
        public EnfantVM(Enfant model)
        {
            this.model = model;
        }
        #endregion
    }
}
