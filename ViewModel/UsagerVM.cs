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
    public class UsagerVM : BaseVM
    {
        #region --------- Attributs ---------
        private Usager model;
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
                this.NotifyPropertyChanged("Nom");
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
                this.NotifyPropertyChanged("Prenom");
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
                this.NotifyPropertyChanged("Genre");
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
                this.NotifyPropertyChanged("DateNaissance");
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
                this.NotifyPropertyChanged("CompositionFamiliale");
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
                this.NotifyPropertyChanged("MotifAdmission");
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
                this.NotifyPropertyChanged("DispositifSortant");
            }
        }

        /// <summary>
        /// Propriété en lecture et écriture sur le sejour d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Sejour Sejour
        {
            get => this.model.Sejour;
            set
            {
                this.model.Sejour = value;
                this.NotifyPropertyChanged("Sejour");
            }
        }

        /// <summary>
        /// Propriété en lecture et écriture sur la profession d'entrées d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Profession ProfessionEntrees
        {
            get => this.model.ProfessionEntrees;
            set
            {
                this.model.ProfessionEntrees = value;
                this.NotifyPropertyChanged("ProfessionEntrees");
            }
        }

        /// <summary>
        /// Propriété en lecture et écriture sur la profession de sortie d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Profession ProfessionSorties
        {
            get => this.model.ProfessionSorties;
            set
            {
                this.model.ProfessionSorties = value;
                this.NotifyPropertyChanged("ProfessionSorties");
            }
        }

        /// <summary>
        /// Propriété en lecture et écriture sur le prescripteur d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Prescripteur Prescripteur
        {
            get => this.model.Prescripteur;
            set
            {
                this.model.Prescripteur = value;
                this.NotifyPropertyChanged("Prescripteur");
            }
        }

        /// <summary>
        /// Propriété en lecture et écriture sur l'ASE d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public ASE Ase
        {
            get => this.model.Ase;
            set
            {
                this.model.Ase = value;
                this.NotifyPropertyChanged("Ase");
            }
        }

        /// <summary>
        /// Propriété en lecture et écriture sur les ressources en entrée d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Ressources RessourcesEntrees
        {
            get => this.model.RessourcesEntrees;
            set
            {
                this.model.RessourcesEntrees = value;
                this.NotifyPropertyChanged("RessourcesEntrees");
            }
        }

        /// <summary>
        /// Propriété en lecture et écriture sur le motif admission d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Ressources RessourcesSorties 
        {
            get => this.model.RessourcesSorties;    
            set
            {
                this.model.RessourcesSorties = value;
                this.NotifyPropertyChanged("RessourcesSorties");
            }
        }

        /// <summary>
        /// Propriété en lecture et écriture sur l'accompagnateur d'un model Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Usager? Accompagnateur
        {
            get => this.model.Accompagnateur;
            set
            {
                this.model.Accompagnateur = value;
                this.NotifyPropertyChanged("Accompagnateur");
            }
        }
        #endregion

        #region --------- Constructeur ---------
        /// <summary>
        /// Constructeur de la classe par défaut
        /// </summary>
        /// <param name="model">objet Usager qui servira de modèle</param>
        /// <author>Lakhdar Gibril</author>
        public UsagerVM (Usager model)
        {
            this.model = model;
        }
        #endregion
    }
}
