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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Lista de usuários do app
                List<DadosUsuario> list_usuarios = new List<DadosUsuario>()
                {
                    new DadosUsuario()
                    {
                        Usuario = "jose",
                        Senha = "123"
                    },
                    new DadosUsuario()
                    {
                        Usuario = "Maria",
                        Senha = "456"
                    }
                };


                /**
                 * Fazendo autenticação
                 */
                DadosUsuario dados_digitados = new DadosUsuario()
                {
                    Usuario = txt_usuario.Text,
                    Senha = txt_senha.Text
                };


                if(list_usuarios.Any(i => (i.Usuario == dados_digitados.Usuario && i.Senha == dados_digitados.Senha) ))
                {
                    
                      // Usuário autenticado, digitou as informações corretamente.
                      App.Current.Properties.Add("usuario_logado", txt_usuario.Text);
                      App.Current.MainPage = new Protegido();
                }
                else
                {
                    // Não preencheu corretamente.
                    throw new Exception("Dados Incorretos, tente novamente.");
                }
                
                
                /*string usuario_correto = "aluno";
                string senha_correta = "123";

                if (txt_usuario.Text == usuario_correto && txt_senha.Text == senha_correta)
                {
                    App.Current.Properties.Add("usuario_logado", txt_usuario.Text);

                    App.Current.MainPage = new Protegido();
                }
                else
                    throw new Exception("Dados Incorretos, tente novamente.");*/

            } catch (Exception ex)
            {
                DisplayAlert("Ooops", ex.Message, "OK");
            }
        }
    }
}