using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    /// <summary>
    /// Classe représentant une vue modèle pour la notion de famille
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class FamilleVM : BaseVM
    {
        #region --------- Attributs ---------
        private Famille model;
        private ObservableCollection<UsagerVM> usagerVMs;
        private ObservableCollection<EnfantVM> enfantVMs;
        #endregion

        #region  --------- Propriétés ---------
        /// <summary>
        /// Propriété en lecture seule permettant de récupérer le model de Famille 
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public Famille Model => this.model;

        /// <summary>
        /// Propriété en lecture seule permettant de récupérer les parents de la Famille
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public ObservableCollection<UsagerVM> UsagerVMs => this.usagerVMs;


        /// <summary>
        /// Propriété en lecture seule permettant de récupérer les enfants de Famille
        /// </summary>
        /// <author>Lakhdar Gibril</author>
        public ObservableCollection<EnfantVM> EnfantVMs => this.enfantVMs;
        #endregion

        #region --------- Constructeur ---------

        /// <summary>
        /// Constructeur naturel de la classe
        /// </summary>
        /// <param name="model">objet Famille qui servira de model</param>
        /// <author>Lakhdar Gibril</author>
        public FamilleVM(Famille model)
        {
            this.model = model;
            this.usagerVMs = new ObservableCollection<UsagerVM>();
            this.enfantVMs = new ObservableCollection<EnfantVM>();

            this.InitFamille(model);
        }
        #endregion

        #region --------- Méthodes ---------
        private void InitFamille(Famille famille)
        {
            foreach (Usager usager in famille.Usagers)
            {
                this.usagerVMs.Add(new UsagerVM(usager));
            }

            foreach (Enfant enfant in famille.Enfants)
            {
                this.enfantVMs.Add(new EnfantVM(enfant));
            }
        }

        /// <summary>
        /// Permet d'ajouter un enfant dans la famille
        /// </summary>
        /// <param name="enfant">une vue modèle d'enfant pour obtenir le modèle</param>
        public void AjouterEnfant (EnfantVM enfant)
        {
            this.model.AjouterEnfant(enfant.Model);
            this.EnfantVMs.Add(enfant);
        }

        /// <summary>
        /// Permet de supprimer un enfant de la famille
        /// </summary>
        /// <param name="enfant">une vue modèle d'enfant pour obtenir le modèle</param>
        public void SupprimerEnfant (EnfantVM enfant)
        {
            this.model.SupprimerEnfant(enfant.Model);
            this.EnfantVMs.Remove(enfant);
        }
        #endregion
    }
}
