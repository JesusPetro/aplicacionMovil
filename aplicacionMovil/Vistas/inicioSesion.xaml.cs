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
    public partial class inicioSesion : ContentPage
    {
        private string user, pass, correo;
        public inicioSesion(string _user, string _pass, string _correo)
        {
            user = _user;
            pass = _pass;
            correo = _correo;  
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (User.Text == user && Pass.Text == pass)
                Navigation.PushAsync(new menuPrincipal(user,correo, pass));
            else
                DisplayAlert("Ops.. ", "Username or Password is incorrect!", "Ok");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new registerPage());
        }
    }
}