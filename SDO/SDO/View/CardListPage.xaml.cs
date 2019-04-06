using SDO.Models.Yugioh;
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
	public partial class CardListPage : ContentPage
	{
		public CardListPage ()
		{
			InitializeComponent ();

            this.BindingContext = new CardListViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var args = (YugiohGameCard)e.Item;

            Navigation.PushModalAsync(new ViewIndividualCardPage(args));
        }
    }
}