using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using aplicacionMovil.Vistas;

namespace aplicacionMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage (new inicioSesion("0","1","2")); 
            /*Colocamos valores aleatorios suponiendo que nunca colocara eso de usuario y de contraseña*/
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
