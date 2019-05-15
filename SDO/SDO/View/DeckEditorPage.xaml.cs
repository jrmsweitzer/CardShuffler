using SDO.Models;
using SDO.Models.Yugioh;
using SDO.Services;
using SDO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDO.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeckEditorPage : ContentPage
	{
		public DeckEditorPage ()
		{
			InitializeComponent ();

            this.BindingContext = new DeckEditorPageViewModel();
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var card = (YugiohGameCard)e.Item;
            ((DeckEditorPageViewModel)BindingContext).SelectedCard = card;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var card = ((DeckEditorPageViewModel)BindingContext).SelectedCard;
            Navigation.PushModalAsync(new ViewIndividualCardPage(card));
        }
    }
}