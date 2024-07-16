using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    /// <summary>
    /// Classe UsagerVM représentant une vue model pour la classe Usager
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class UsagerVM : INotifyPropertyChanged
    {
        #region --------- Attributs ---------
        private Usager model;
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Propriété en lecture seule permettant de récupérer l'objet servant de model
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Usager Model => this.model;

        /// <summary>
        /// Propriété en lecture seule permettant de récupérer l'identifiant du model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int IdUsager => this.model.IdUsager;

        /// <summary>
        /// Propriété en lecture seule permettant de récupérer le nom du model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Nom
        {
            get => this.model.Nom;
            set
            {
                this.model.Nom = value;
            }
        }


        /// <summary>
        /// Propriété en lecture seule permettant de récupérer le prénom du model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Prenom
        {
            get => this.model.Prenom;
            set
            {
                this.model.Prenom = value;
            }
        }


        /// <summary>
        /// Propriété en lecture seule permettant de récupérer le genre du model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Genre
        {
            get => this.model.Genre;
            set
            {
                this.model.Genre = value;
            }
        }


        /// <summary>
        /// Propriété en lecture seule permettant de récupérer la date de naissance du model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public DateTime DateNaissance
        {
            get => this.model.DateNaissance;
            set
            {
                this.model.DateNaissance = value;
            }
        }

        /// <summary>
        /// Propriété en lecture seule permettant de récupérer la composition familiale du model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string CompositionFamiliale
        {
            get => this.model.CompositionFamiliale;
            set
            {
                this.model.CompositionFamiliale = value;
            }
        }

        /// <summary>
        /// Propriété en lecture et écriture sur le motif admission d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string MotifAdmission
        {
            get => this.model.MotifAdmission;
            set
            {
                this.model.MotifAdmission = value;
            }
        }


        /// <summary>
        /// Propriété en lecture et écriture sur le motif admission d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string DispositifSortant
        {
            get => this.model.DispositifSortant;
            set
            {
                this.model.DispositifSortant = value;
            }
        }
        #endregion
    }
}
