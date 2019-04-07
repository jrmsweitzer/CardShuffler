using SDO.Models;
using SDO.Models.Yugioh;
using SDO.Models.Yugioh.YugiohCards;
using SDO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SDO.ViewModel
{
    public class DeckEditorPageViewModel: ViewModelBase
    {
        private List<YugiohGameCard> Cards;
        public DeckEditorPageViewModel()
        {
            Cards = new CardService().GetAllCards();
        }

        public ICollection<YugiohGameCard> FilteredCards
        {
            get
            {
                return Cards
                    .Where(c => c.Name.ToLower().Contains(SearchName.ToLower()))
                    .Where(c => c.Description.ToLower().Contains(SearchDescription.ToLower()))
                    .ToList();
            }
        }

        private List<YugiohGameCard> _currentDeck;
        public List<YugiohGameCard> CurrentDeck
        {
            get
            {
                if (_currentDeck == null)
                    _currentDeck = new List<YugiohGameCard>()
                    {
                        new AmazonessSwordsWoman(null)
                    };
                return _currentDeck;
            }
            set
            {
                SetProperty(ref _currentDeck, value);
            }
        }

        private bool _isCardSelected = false;
        public bool IsCardSelected
        {
            get { return _isCardSelected; }
            set
            {
                SetProperty(ref _isCardSelected, value);
            }
        }
        
        public bool IsAddToDeckButtonEnabled
        {
            get
            {
                if (SelectedCard == null) return false;
                if (CurrentDeck.Where(c => c.Name == SelectedCard.Name).Count() == 3) return false;
                return true;
            }
        }
        
        public bool IsRemoveFromDeckButtonEnabled
        {
            get
            {
                if (SelectedCard == null) return false;
                return CurrentDeck.Any(c => c.Name == SelectedCard.Name);
            }
        }

        private string _searchName = string.Empty;
        public string SearchName
        {
            get { return _searchName; }
            set
            {
                SetProperty(ref _searchName, value);
                UpdateSearch();
            }
        }

        private YugiohGameCard _selectedCard = null;
        public YugiohGameCard SelectedCard
        {
            get { return _selectedCard; }
            set
            {
                SetProperty(ref _selectedCard, value);
                IsCardSelected = true;
                OnPropertyChanged(nameof(IsAddToDeckButtonEnabled));
                OnPropertyChanged(nameof(IsRemoveFromDeckButtonEnabled));
            }
        }

        private string _searchDescription = string.Empty;
        public string SearchDescription
        {
            get { return _searchDescription; }
            set
            {
                SetProperty(ref _searchDescription, value);
                UpdateSearch();
            }
        }

        public ICommand AddToDeckButtonClicked
        {
            get
            {
                return new Command(() => 
                {
                    CurrentDeck.Add(SelectedCard);
                    SelectedCard = null;
                    UpdateDeck();
                });
            }
        }

        public ICommand RemoveFromDeckButtonClicked
        {
            get
            {
                return new Command(() => 
                {
                    CurrentDeck.ToList().Remove(SelectedCard);
                    SelectedCard = null;
                    UpdateDeck();
                });
            }
        }

        private void UpdateSearch()
        {
            OnPropertyChanged(nameof(FilteredCards));
        }

        private void UpdateDeck()
        {
            //SetProperty(ref _currentDeck, CurrentDeck);
            OnPropertyChanged(nameof(CurrentDeck));
        }
    }
}
