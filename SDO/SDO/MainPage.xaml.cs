using SDO.Models;
using SDO.Models.Yugioh;
using SDO.ViewModel;
using Xamarin.Forms;

namespace SDO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new CardListViewModel();
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            //var s = sender;
        }
    }
}
