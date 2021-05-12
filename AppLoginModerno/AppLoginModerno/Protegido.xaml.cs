using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoginModerno
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Protegido : ContentPage
    {
        public Protegido()
        {
            InitializeComponent();

            lbl_boasvindas.Text = string.Format(
                "Bem-vindo (a) {0} ",
                App.Current.Properties["usuario_logado"].ToString()
            );
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool confirmacao = await DisplayAlert("Tem certeza?", "Sair do App?", "Sim", "Não");

            if(confirmacao)
            {
                App.Current.Properties.Remove("usuario_logado");

                App.Current.MainPage = new Login();
            }
               
        }
    }
}