using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JavaPointTutorial_XamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Login was successful", "OK");
            new NavigationPage(new Page1());
        }
    }
}