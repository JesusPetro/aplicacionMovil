using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicacionMovil.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registerPage : ContentPage
    {

        public registerPage()
        {
            InitializeComponent();
        }

        private void cbox_terminos_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbox_terminos.IsChecked)
                btn_registrar.IsEnabled = true;
            else
                btn_registrar.IsEnabled = false;
        }

        private void btn_registrar_Clicked(object sender, EventArgs e)
        {
            if (lbl_password.Text == lbl_password2.Text)
            {
                string auxUser = lbl_usuario.Text;
                string auxPassword = lbl_password.Text;
                string auxCorreo = lbl_correo.Text;
                limpiarRegistros();
                DisplayAlert("Registro exitoso!", "Su cuenta ha sido creada exitosamente.", "Vale");
                Navigation.PushAsync(new inicioSesion(auxUser, auxPassword, auxCorreo));
            }

            else
            {
                DisplayAlert("Contraseña incorrecta!", "Digite nuevamente las contraseñas", "Vale");
                lbl_password.Text = "";
                lbl_password2.Text = "";
            }


        }

        private void limpiarRegistros()
        {
            lbl_usuario.Text = "";
            lbl_correo.Text = "";
            lbl_password.Text = "";
            lbl_password2.Text = "";
            progress.ProgressTo(0, 250, Easing.Linear);
        }

        private void lbl_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            String usuario = lbl_usuario.Text.ToString();
            string cadena = $"Bienvenido {usuario}. Llene sus datos";
            lbl_principal.Text = cadena;
        }

        private void lbl_nombre_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.25, 250, Easing.Linear);
            lbl_progress.Text = "25%";
        }


        private void lbl_correo_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.5, 250, Easing.Linear);
            lbl_progress.Text = "50%";
        }

        private void lbl_password_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.75, 250, Easing.Linear);
            lbl_progress.Text = "75%";
        }

        private void lbl_password2_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(1, 250, Easing.Linear);
            lbl_progress.Text = "100%";
        }
    }
}