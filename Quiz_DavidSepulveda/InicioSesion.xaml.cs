using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quiz_DavidSepulveda
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Page
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text == "David" && txtPassword.Password == "1234")
            {
                
                MainWindow navegar = (MainWindow)Window.GetWindow(this);
                navegar.frameLogin.NavigationService.Navigate(new Home());
                
               
            }
            else
            {
                txtUsuario.Text = "";
                txtPassword.Password = "";
                MessageBox.Show("Usuario o Clave incorrecta");
            }
        }
    }
}
