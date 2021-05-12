using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoginModerno
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if(Properties.ContainsKey("usuario_logado"))
            {
                MainPage = new Protegido();

            } else
                MainPage = new Login();
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
