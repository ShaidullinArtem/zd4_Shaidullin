using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4_Shaidullin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signin_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(pass.Text))
            {
                DisplayAlert("Ошибка", "Заполните все поля", "Окей");
                return;
            }
            Navigation.PushAsync(new MainPage(login.Text, pass.Text));
        }
    }
}