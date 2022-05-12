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
    public partial class menuPrincipal : ContentPage
    {
        private string usu, correo, contra;
        public menuPrincipal(string _usu, string _correo, string _contra)
        {
            usu = _usu;
            correo= _correo;
            contra = _contra;
            InitializeComponent();
            Lable.Text = $"Usuario:  {usu} \nCorreo:  {correo}";

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new inicioSesion(usu, contra, correo));
        }

    }
}