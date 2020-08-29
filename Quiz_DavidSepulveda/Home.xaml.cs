using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            cmbCategoria.Items.Add("Pollo queso");
            cmbCategoria.Items.Add("Carnes frias");
            cmbCategoria.Items.Add("Llanera");
            cmbCategoria.Items.Add("The Chavez");
            cmbCategoria.Items.Add("Hawaiana");
            cmbVegana.Items.Add("Mamma Tomato");
            cmbVegana.Items.Add("Morelia");
            cmbVegana.Items.Add("Veggie Pizza");
            cmbVegana.Items.Add("The Chavez");
            cmbVegana.Items.Add("Green's Pizza");

        }

        

        private void cbxCarnes_Checked(object sender, RoutedEventArgs e)
        {
            if(cbxCarnes.IsChecked==true)
            {
                cmbCategoria.Visibility = Visibility.Visible;
            }
            

        }

       

        private void cbxVegana_Checked(object sender, RoutedEventArgs e)
        {
            if(cbxVegana.IsChecked==true)
            {
                cmbVegana.Visibility = Visibility.Visible;
            }
        }

        private void cbxVegana_Unchecked(object sender, RoutedEventArgs e)
        {
            cmbVegana.Visibility = Visibility.Hidden;
        }

        private void cbxCarnes_Unchecked(object sender, RoutedEventArgs e)
        {
            cmbCategoria.Visibility = Visibility.Hidden;
        }

        

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
               if(cbxCarnes.IsChecked==true)
            {
                lblPrecio.Visibility = Visibility.Visible;
                txtCarrito.Items.Add(cmbCategoria.SelectedItem);
                 lblPrecio.Content = "$" + (txtCarrito.Items.Count * 16000);
            }
            else
            {
                lblPrecio.Visibility = Visibility.Visible;
                txtCarrito.Items.Add(cmbVegana.SelectedItem);
                lblPrecio.Content = "$" + (txtCarrito.Items.Count * 16000);
            }   

                
            
            
           
        }
        

        private void btnAgendar_Click(object sender, RoutedEventArgs e)
        {
            lblFecha.Content = calAlmanaque.SelectedDate.ToString();
            lblFecha.Visibility = Visibility.Visible;
        }

        private void btnPedido_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Tu pedido ha sido exitoso. Gracias por tu pedido");
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow navegar = (MainWindow)Window.GetWindow(this);
            navegar.frameLogin.NavigationService.Navigate(new InicioSesion());
        }

        private void btnQuitar_Click(object sender, RoutedEventArgs e)
        {
            if (cbxCarnes.IsChecked == true)
            {

                txtCarrito.Items.Remove(cmbCategoria.SelectedItem);
                lblPrecio.Content = "$" + (txtCarrito.Items.Count * (32000 - 16000));
            }
            else
            {
                txtCarrito.Items.Remove(cmbVegana.SelectedItem);
                lblPrecio.Content = "$" + (txtCarrito.Items.Count * (32000 - 16000));
            }
        } 

        
    }
}
