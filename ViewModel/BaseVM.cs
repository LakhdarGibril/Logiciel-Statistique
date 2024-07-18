using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    /// <summary>
    /// Classe réprésentant une classe de base pour les autres vue model
    /// </summary>
    /// <author>Lakhdar Gibril</author>
    public class BaseVM : INotifyPropertyChanged
    {
        #region --------- Méthodes ---------
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
