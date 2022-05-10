using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace myapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_sesion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new sesion2(" "," "," "));
            limpiarRegistros();   
            
;
        }
        private void limpiarRegistros()
        {
            lbl_nombre.Text = "";
            lbl_apellido.Text = "";
            lbl_correo.Text = "";
            lbl_password.Text = "";
        }

        private void lbl_password_Completed(object sender, EventArgs e)
        {


        }

        private void lbl_correo_Completed(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            String nombre = lbl_nombre.Text.ToString();
       

        }

        private void lbl_apellido_Completed(object sender, EventArgs e)
        {
            String apellido = lbl_apellido.Text.ToString();

        }
    }
}
