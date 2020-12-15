using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JavaPointTutorial_XamarinForm
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Detail = new NavigationPage(new Login());
            //IsPresented = true;
        }

        public void button_clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
        }

        public void button_clicked1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
            IsPresented = false;
        }

        private void login_btn_clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Login());
            IsPresented = false;
        }
    }
}
