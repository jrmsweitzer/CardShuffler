using SDO.Models;
using SDO.Models.Yugioh;
using SDO.View;
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

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var args = (YugiohGameCard)e.Item;

            Navigation.PushModalAsync(new ViewIndividualCardPage(args));
        }
    }
}
