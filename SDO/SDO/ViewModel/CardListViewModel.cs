using SDO.Models.Yugioh;
using SDO.Models.Yugioh.YugiohCardTypes;
using SDO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SDO.ViewModel
{
    public class CardListViewModel: ViewModelBase
    {
        public CardListViewModel()
        {
            var service = new CardService();
            Cards = service.GetAllCards();
        }

        private List<YugiohGameCard> cards;
        public List<YugiohGameCard> Cards
        {
            get { return cards; }
            set { SetProperty(ref cards, value); }
        }

        public List<YugiohGameCard> FilteredCards
        {
            get
            {
                var nameFilteredCards = string.IsNullOrEmpty(_cardSearchFilter) ? cards :
                    cards.Where(c => c.Name.ToLower().Contains(_cardSearchFilter.ToLower())).ToList();

                switch (_selectedCardType)
                {
                    case "Monsters":
                        return nameFilteredCards.Where(c => c is Monster).ToList();
                    case "Spells":
                        return nameFilteredCards.Where(c => c is Spell).ToList();
                    case "Traps":
                        return nameFilteredCards.Where(c => c is Trap).ToList();
                    case "Skills":
                        return nameFilteredCards.Where(c => c is Skill).ToList();
                    default:
                        return nameFilteredCards;
                }
            }
        }

        private string _selectedCardType = "All";
        public string SelectedCardType
        {
            get { return _selectedCardType; }
            set
            {
                SetProperty(ref _selectedCardType, value);
                OnPropertyChanged(nameof(FilteredCards));
            }
        }

        private string _cardSearchFilter = string.Empty;
        public string CardSearchFilter
        {
            get { return _cardSearchFilter; }
            set
            {
                SetProperty(ref _cardSearchFilter, value);
                OnPropertyChanged(nameof(FilteredCards));
            }
        }

        public List<string> SelectCardType
        {
            get
            {
                return new List<string>()
                {
                    "All",
                    "Monsters",
                    "Spells",
                    "Traps",
                    "Skills"
                };
            }
        }
    }
}
