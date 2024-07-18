using Exceptions;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HMI
{
    /// <summary>
    /// Logique d'interaction pour LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        #region --------- Attributs ---------
        private Utilisateur? utilisateur;
        #endregion 

        #region --------- Constructeur ---------
        public LoginScreen()
        {
            InitializeComponent();
        }
        #endregion

        #region --------- Méthodes ---------
        private void usernameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                this.usernameTextBox.Text = "Nom d'utilisateur";
            }
        }

        private void usernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (this.usernameTextBox.Text == "Nom d'utilisateur")
            {
                this.usernameTextBox.Text = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.usernameTextBox.Text.Contains("Nom d'utilisateur")) throw new ConnexionException("Aucun identifiant de connexion n'a été entré.");
                else
                {
                    this.utilisateur = new Utilisateur(this.usernameTextBox.Text);
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                
            }
            catch (Exception exception) 
            {
                MessageBox.Show(exception.Message, "Erreur utilisateur", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
        }
        #endregion
    }
}
