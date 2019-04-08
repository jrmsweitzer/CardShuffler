using Newtonsoft.Json;
using SDO.Models.Yugioh;
using SDO.Models.Yugioh.YugiohCardTypes;
using SDO.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Windows.Input;
using Xamarin.Forms;

namespace SDO.ViewModel
{
    public class DeckEditorPageViewModel: ViewModelBase
    {
        private ObservableCollection<YugiohGameCard> Cards;
        private CardService _cardSvc;


        public DeckEditorPageViewModel()
        {
            Cards = new ObservableCollection<YugiohGameCard>(new CardService().GetAllCards());
            _cardSvc = new CardService();
            UpdateUI();
        }

        public ObservableCollection<YugiohGameCard> FilteredCards
        {
            get
            {
                return new ObservableCollection<YugiohGameCard>(Cards
                    .Where(c => c.Name.ToLower().Contains(SearchName.ToLower()))
                    .Where(c => c.Description.ToLower().Contains(SearchDescription.ToLower()))
                    .OrderBy(c => c.Name));
            }
        }

        private ObservableCollection<YugiohGameCard> _mainDeck;
        public ObservableCollection<YugiohGameCard> MainDeck
        {
            get
            {
                if (_mainDeck == null)
                    _mainDeck = new ObservableCollection<YugiohGameCard>();
                return _mainDeck;
            }
            set
            {
                SetProperty(ref _mainDeck, value);
            }
        }

        public string MainDeckCountText
        {
            get
            {
                return $"Main Deck: {MainDeck.Where(c => c is Skill == false).Count()}/30";
            }
        }

        private ObservableCollection<YugiohGameCard> _sideDeck;
        public ObservableCollection<YugiohGameCard> SideDeck
        {
            get
            {
                if (_sideDeck == null)
                    _sideDeck = new ObservableCollection<YugiohGameCard>();
                return _sideDeck;
            }
            set
            {
                SetProperty(ref _sideDeck, value);
            }
        }

        public string SideDeckCountText
        {
            get
            {
                return $"Side Deck: {SideDeck.Count}/5";
            }
        }

        private ObservableCollection<YugiohGameCard> _fusionDeck;
        public ObservableCollection<YugiohGameCard> FusionDeck
        {
            get
            {
                if (_fusionDeck == null)
                    _fusionDeck = new ObservableCollection<YugiohGameCard>();
                return _fusionDeck;
            }
            set
            {
                SetProperty(ref _fusionDeck, value);
            }
        }

        public string FusionDeckCountText
        {
            get
            {
                return $"Fusion Deck: {FusionDeck.Count}/5";
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
                if (MainDeck.Where(c => c is Skill == false).Count() == 30) return false;
                if (SelectedCard == null) return false;
                if (SelectedCard is FusionMonster) return false;
                if (SelectedCard is Skill && MainDeck.Where(c => c is Skill).Count() == 1) return false;
                if (SideDeck.Any(c => c is Skill s && s.Name == SelectedCard.Name)) return false;

                if (MainDeck.Where(c => c.Name == SelectedCard.Name).Count() +
                    SideDeck.Where(c => c.Name == SelectedCard.Name).Count() == 3) return false;
                return true;
            }
        }

        public bool IsRemoveFromDeckButtonEnabled
        {
            get
            {
                if (SelectedCard == null) return false;
                return MainDeck.Any(c => c.Name == SelectedCard.Name);
            }
        }

        public bool IsAddToFusionDeckButtonEnabled
        {
            get
            {
                if (FusionDeck.Count == 5) return false;
                if (SelectedCard == null) return false;
                if (SelectedCard is FusionMonster == false) return false;
                if (FusionDeck.Where(c => c.Name == SelectedCard.Name).Count() +
                    SideDeck.Where(c => c.Name == SelectedCard.Name).Count() == 3) return false;
                return true;
            }
        }

        public bool IsRemoveFromFusionDeckButtonEnabled
        {
            get
            {
                if (SelectedCard == null) return false;
                return FusionDeck.Any(c => c.Name == SelectedCard.Name);
            }
        }

        public bool IsAddToSideDeckButtonEnabled
        {
            get
            {
                if (SideDeck.Count == 5) return false;
                if (SelectedCard == null) return false;

                if (SelectedCard is Skill sideDeckSkill)
                {
                    if (MainDeck.Any(c => c is Skill s && s.Name == sideDeckSkill.Name)) return false;
                    if (SideDeck.Any(c => c is Skill s && s.Name == sideDeckSkill.Name)) return false;

                    if (MainDeck.Any(c => c is Skill))
                    {
                        var mainDeckSkill = (Skill)MainDeck.FirstOrDefault(c => c is Skill);
                        return mainDeckSkill.Character == sideDeckSkill.Character;
                    }
                    else
                        return false;
                }

                if (SelectedCard is FusionMonster)
                {
                    if (FusionDeck.Where(c => c.Name == SelectedCard.Name).Count() +
                        SideDeck.Where(c => c.Name == SelectedCard.Name).Count() == 3) return false;
                }
                else if (MainDeck.Where(c => c.Name == SelectedCard.Name).Count() +
                    SideDeck.Where(c => c.Name == SelectedCard.Name).Count() == 3) return false;

                return true;
            }
        }

        public bool IsRemoveFromSideDeckButtonEnabled
        {
            get
            {
                if (SelectedCard == null) return false;
                return SideDeck.Any(c => c.Name == SelectedCard.Name);
            }
        }

        private string _searchName = string.Empty;
        public string SearchName
        {
            get { return _searchName; }
            set
            {
                SetProperty(ref _searchName, value);
                UpdateUI();
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
                OnPropertyChanged(nameof(IsAddToFusionDeckButtonEnabled));
                OnPropertyChanged(nameof(IsRemoveFromFusionDeckButtonEnabled));
                OnPropertyChanged(nameof(IsAddToSideDeckButtonEnabled));
                OnPropertyChanged(nameof(IsRemoveFromSideDeckButtonEnabled));
            }
        }

        private string _searchDescription = string.Empty;
        public string SearchDescription
        {
            get { return _searchDescription; }
            set
            {
                SetProperty(ref _searchDescription, value);
                UpdateUI();
            }
        }

        private string _deckName;
        public string DeckName
        {
            get
            {
                if (string.IsNullOrEmpty(_deckName))
                    _deckName = string.Empty;
                return _deckName;
            }
            set
            {
                SetProperty(ref _deckName, value);
                UpdateUI();
            }
        }

        public bool IsSaveDeckButtonEnabled
        {
            get
            {
                if (MainDeck.Count + FusionDeck.Count + SideDeck.Count == 0)
                    return false;
                if (string.IsNullOrEmpty(DeckName))
                    return false;
                return true;
            }
        }

        public ICommand SaveDeck
        {
            get
            {
                return new Command(async () =>
                {
                    var deckName = DeckName;
                    var md = MainDeck;
                    var sd = SideDeck;
                    var fd = FusionDeck;

                    var deckList = _cardSvc.BuildDecklistFromDecks(md.ToList(), fd.ToList(), sd.ToList());

                    //var deck = new DB.Deck()
                    //{
                    //    PlayerID = 0,
                    //    Decklist = deckList,
                    //    Name = deckName,
                    //};

                    using (var client = new HttpClient())
                    {
                        var uri = "http://sdoapi.azurewebsites.net/api/";

                        client.BaseAddress = new System.Uri(uri);

                        var responseTask = client.GetAsync("cards");

                        var result = responseTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            var readTask = result.Content.ReadAsStreamAsync();
                            readTask.Wait();

                            var cards = readTask.Result;
                        }
                        else //web api sent error response 
                        {
                            //log response status here..

                            //students = Enumerable.Empty<StudentViewModel>();

                            //ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                        }
                    }
                });
            }
        }

        public ICommand AddToDeckButtonClicked
        {
            get
            {
                return new Command(() =>
                {
                    MainDeck.Add(SelectedCard);

                    if (MainDeck.Any(c => c is Skill))
                    {
                        var skill = MainDeck.First(c => c is Skill);
                        var list = new List<YugiohGameCard>() { skill };
                        foreach (var card in MainDeck.Where(c => c is Skill == false).OrderBy(c => c.Name))
                        {
                            list.Add(card);
                        }
                        MainDeck = new ObservableCollection<YugiohGameCard>(list);
                    }
                    else
                    {
                        MainDeck = new ObservableCollection<YugiohGameCard>(MainDeck.OrderBy(c => c.Name).ToList());
                    }
                    UpdateUI();
                });
            }
        }

        public ICommand RemoveFromDeckButtonClicked
        {
            get
            {
                return new Command(() =>
                {
                    var index = MainDeck.ToList().FindIndex(c => c.Name == SelectedCard.Name);
                    MainDeck.RemoveAt(index);
                    UpdateUI();
                });
            }
        }

        public ICommand AddToFusionDeckButtonClicked
        {
            get
            {
                return new Command(() =>
                {
                    FusionDeck.Add(SelectedCard);
                    FusionDeck = new ObservableCollection<YugiohGameCard>(FusionDeck.OrderBy(c => c.Name).ToList());
                    UpdateUI();
                });
            }
        }

        public ICommand RemoveFromFusionDeckButtonClicked
        {
            get
            {
                return new Command(() =>
                {
                    var index = FusionDeck.ToList().FindIndex(c => c.Name == SelectedCard.Name);
                    FusionDeck.RemoveAt(index);
                    UpdateUI();
                });
            }
        }

        public ICommand AddToSideDeckButtonClicked
        {
            get
            {
                return new Command(() =>
                {
                    SideDeck.Add(SelectedCard);
                    SideDeck = new ObservableCollection<YugiohGameCard>(SideDeck.OrderBy(c => c.Name).ToList());
                    UpdateUI();
                });
            }
        }

        public ICommand RemoveFromSideDeckButtonClicked
        {
            get
            {
                return new Command(() =>
                {
                    var index = SideDeck.ToList().FindIndex(c => c.Name == SelectedCard.Name);
                    SideDeck.RemoveAt(index);
                    UpdateUI();
                });
            }
        }

        public ICommand ListView_ItemTapped
        {
            get
            {
                return new Command(() =>
                {
                    var card = Cards.FirstOrDefault();
                    SelectedCard = card;
                });
            }
        }

        public ICommand ClearDeck
        {
            get
            {
                return new Command(() =>
                {
                    MainDeck.Clear();
                    SideDeck.Clear();
                    FusionDeck.Clear();
                    UpdateUI();
                });
            }
        }

        private void UpdateUI()
        {
            OnPropertyChanged(nameof(FilteredCards));

            OnPropertyChanged(nameof(MainDeck));
            OnPropertyChanged(nameof(MainDeckCountText));
            OnPropertyChanged(nameof(IsAddToDeckButtonEnabled));
            OnPropertyChanged(nameof(IsRemoveFromDeckButtonEnabled));

            OnPropertyChanged(nameof(FusionDeck));
            OnPropertyChanged(nameof(FusionDeckCountText));
            OnPropertyChanged(nameof(IsAddToFusionDeckButtonEnabled));
            OnPropertyChanged(nameof(IsRemoveFromFusionDeckButtonEnabled));

            OnPropertyChanged(nameof(SideDeck));
            OnPropertyChanged(nameof(SideDeckCountText));
            OnPropertyChanged(nameof(IsAddToSideDeckButtonEnabled));
            OnPropertyChanged(nameof(IsRemoveFromSideDeckButtonEnabled));

            OnPropertyChanged(nameof(IsSaveDeckButtonEnabled));
        }
    }
}
