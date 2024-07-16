using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Représente un Usager avec un nom, un prénom, un genre... Présent au sein de l'association.
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class Usager
    {
        #region --------- Attributs ---------
        private int idUsager;
        private string nom;
        private string prenom;
        private string genre;
        private DateTime dateNaissance;
        private string compositionFamiliale;
        private string motifAdmission;
        private string dispositifSortant;

        private Sejour sejour;
        private Profession professionEntrees;
        private Profession professionSorties;
        private Prescripteur prescripteur;
        private ASE ase;
        private Ressources ressourcesEntrees;
        private Ressources ressourcesSorties;
        private Usager? accompagnateur;
        #endregion

        #region --------- Propriétés ---------
        /// <summary>
        /// Retourne ou modifie l'identifiant d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public int IdUsager { get => idUsager; set => idUsager = value; }

        /// <summary>
        /// Retourne ou modifie le nom d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Nom { get => nom; set => nom = value; }

        /// <summary>
        /// Retourne ou modifie le prénom d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Prenom { get => prenom; set => prenom = value; }

        /// <summary>
        /// Retourne ou modifie le genre d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string Genre { get => genre; set => genre = value; }

        /// <summary>
        /// Retourne ou modifie la date de naissance d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }

        /// <summary>
        /// Retourne ou modifie la composition familiale d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string CompositionFamiliale { get => compositionFamiliale; set => compositionFamiliale = value; }

        /// <summary>
        /// Retourne ou modifie le motif d'admission d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string MotifAdmission { get => motifAdmission; set => motifAdmission = value; }

        /// <summary>
        /// Retourne ou modifie le dispositif sortant d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public string DispositifSortant { get => dispositifSortant; set => dispositifSortant = value; }

        /// <summary>
        /// Retourne ou modifie le sejour d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Sejour Sejour { get => sejour; set => sejour = value; }

        /// <summary>
        /// Retourne ou modifie la profession d'entrée d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Profession ProfessionEntrees { get => professionEntrees; set => professionEntrees = value; }

        /// <summary>
        /// Retourne ou modifie la profession de sortie d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Profession ProfessionSorties { get => professionSorties; set => professionSorties = value; }

        /// <summary>
        /// Retourne ou modifie le prescripteur d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Prescripteur Prescripteur { get => prescripteur; set => prescripteur = value; }

        /// <summary>
        /// Retourne ou modifie l'ASE connu d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public ASE Ase { get => ase; set => ase = value; }

        /// <summary>
        /// Retourne ou modifie les ressources en entrées d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Ressources RessourcesEntrees { get => ressourcesEntrees; set => ressourcesEntrees = value; }

        /// <summary>
        /// Retourne ou modifie les ressources en sortie d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Ressources RessourcesSorties { get => ressourcesSorties; set => ressourcesSorties = value; }

        /// <summary>
        /// Retourne ou modifie l'accompagnateur d'un Usager
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Usager? Accompagnateur { get => accompagnateur; set => accompagnateur = value; }
        #endregion

        #region --------- Constructeur & Destructeur ---------

        /// <summary>
        /// Constructeur naturel par défaut
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Usager()
        {
            this.idUsager = 0;
            this.nom = string.Empty;
            this.prenom = string.Empty;
            this.genre = string.Empty;
            this.dateNaissance = DateTime.Now;
            this.compositionFamiliale = string.Empty;
            this.motifAdmission = string.Empty;
            this.dispositifSortant = string.Empty;

            this.sejour = new Sejour();
            this.professionEntrees = new Profession(string.Empty);
            this.professionSorties = new Profession(string.Empty);
            this.prescripteur = new Prescripteur(string.Empty);
            this.ase = new ASE(string.Empty);
            this.ressourcesEntrees = new Ressources();
            this.ressourcesSorties = new Ressources();
        }

        /// <summary>
        /// Destructeur naturel par défaut
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        ~Usager() { }
        #endregion

        #region --------- Méthodes ---------
        public override string ToString()
        {
            return $"{this.nom} {this.prenom}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Usager usager &&
                   idUsager == usager.idUsager &&
                   nom == usager.nom &&
                   prenom == usager.prenom &&
                   genre == usager.genre &&
                   dateNaissance == usager.dateNaissance &&
                   compositionFamiliale == usager.compositionFamiliale &&
                   motifAdmission == usager.motifAdmission &&
                   dispositifSortant == usager.dispositifSortant &&
                   EqualityComparer<Sejour>.Default.Equals(sejour, usager.sejour) &&
                   EqualityComparer<Profession>.Default.Equals(professionEntrees, usager.professionEntrees) &&
                   EqualityComparer<Profession>.Default.Equals(professionSorties, usager.professionSorties) &&
                   EqualityComparer<Prescripteur>.Default.Equals(prescripteur, usager.prescripteur) &&
                   EqualityComparer<ASE>.Default.Equals(ase, usager.ase) &&
                   EqualityComparer<Ressources>.Default.Equals(ressourcesEntrees, usager.ressourcesEntrees) &&
                   EqualityComparer<Ressources>.Default.Equals(ressourcesSorties, usager.ressourcesSorties) &&
                   EqualityComparer<Usager?>.Default.Equals(accompagnateur, usager.accompagnateur);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(idUsager);
            hash.Add(nom);
            hash.Add(prenom);
            hash.Add(genre);
            hash.Add(dateNaissance);
            hash.Add(compositionFamiliale);
            hash.Add(motifAdmission);
            hash.Add(dispositifSortant);
            hash.Add(sejour);
            hash.Add(professionEntrees);
            hash.Add(professionSorties);
            hash.Add(prescripteur);
            hash.Add(ase);
            hash.Add(ressourcesEntrees);
            hash.Add(ressourcesSorties);
            hash.Add(accompagnateur);
            return hash.ToHashCode();
        }
        #endregion
    }
}
