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
        }

        private void OpenCardList(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new CardListPage());
        }

        private void OpenDeckEditor(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new DeckEditorPage());
        }
    }
}
