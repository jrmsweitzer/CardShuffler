using SDO.Models.Yugioh;
using SDO.Models.Yugioh.YugiohCardTypes;
using SDO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SDO.ViewModel
{
    public class CardListViewModel : ViewModelBase
    {
        public CardListViewModel()
        {
            SetCards();
        }

        private void SetCards()
        {
            var service = new CardService();
            var cards = service.GetAllCards();
            var list = new List<CardViewModel>();

            foreach (var card in cards)
            {
                var cardVm = new CardViewModel { Card = card };


                list.Add(cardVm);
            }

            Cards = list;
        }

        private List<CardViewModel> cards;
        public List<CardViewModel> Cards
        {
            get { return cards; }
            set { SetProperty(ref cards, value); }
        }

        public List<CardViewModel> FilteredCards
        {
            get
            {
                var filteredCards = cards;

                if (_selectedPack != "All")
                {
                    var packCode = PackListWithAbbr.FirstOrDefault(p => p.Key == _selectedPack).Value;
                    filteredCards = filteredCards.Where(vm => vm.Card.SetCodes.Any(sc => sc.StartsWith(packCode))).ToList();
                }

                if (!string.IsNullOrEmpty(_cardSearchFilterName))
                    filteredCards = filteredCards.Where(vm => vm.Card.Name.ToLower().Contains(_cardSearchFilterName.ToLower())).ToList();

                if (!string.IsNullOrEmpty(_cardSearchFilterDescription))
                    filteredCards = filteredCards.Where(vm => vm.Card.Description.ToLower().Contains(_cardSearchFilterDescription.ToLower())).ToList();

                switch (_selectedCardCategory)
                {
                    case "Monsters":
                        filteredCards = filteredCards.Where(vm => vm.Card is Monster).ToList();
                        if (null != _selectedCardType &&
                            "All Monster Types" != _selectedCardType)
                            filteredCards = filteredCards.Where(vm => ((Monster)vm.Card).Type.ToString() == _selectedCardType).ToList();
                        break;
                    case "Spells":
                        filteredCards = filteredCards.Where(vm => vm.Card is Spell).ToList();
                        if ("All Spell Types" != _selectedCardType)
                        {
                            switch (_selectedCardType)
                            {
                                case "Continuous":
                                    filteredCards = filteredCards.Where(vm => vm.Card is ContinuousSpell).ToList();
                                    break;
                                case "Field":
                                    filteredCards = filteredCards.Where(vm => vm.Card is FieldSpell).ToList();
                                    break;
                                case "Ritual":
                                    filteredCards = filteredCards.Where(vm => vm.Card is RitualSpell).ToList();
                                    break;
                                case "Normal":
                                    filteredCards = filteredCards.Where(vm => vm.Card is NormalSpell).ToList();
                                    break;
                                case "Equip":
                                    filteredCards = filteredCards.Where(vm => vm.Card is EquipSpell).ToList();
                                    break;
                                case "QuickPlay":
                                    filteredCards = filteredCards.Where(vm => vm.Card is QuickplaySpell).ToList();
                                    break;
                            }
                        }
                        break;
                    case "Traps":
                        filteredCards = filteredCards.Where(vm => vm.Card is Trap).ToList();
                        if ("All Trap Types" != _selectedCardType)
                        {
                            switch (_selectedCardType)
                            {
                                case "Continuous":
                                    filteredCards = filteredCards.Where(vm => vm.Card is ContinuousTrap).ToList();
                                    break;
                                case "Counter":
                                    filteredCards = filteredCards.Where(vm => vm.Card is CounterTrap).ToList();
                                    break;
                                case "Normal":
                                    filteredCards = filteredCards.Where(vm => vm.Card is NormalTrap).ToList();
                                    break;
                            }
                        }
                        break;
                    case "Skills":
                        filteredCards = filteredCards.Where(vm => vm.Card is Skill).ToList();
                        if (null != _selectedCardType &&
                            "All Characters" != _selectedCardType)
                            filteredCards = filteredCards.Where(vm => ((Skill)vm.Card).Character == _selectedCardType).ToList();
                        break;
                }

                switch (_sortBy)
                {
                    case "Alphabetical":
                        filteredCards = filteredCards.OrderBy(vm => vm.Card.Name).ToList();
                        break;
                    case "Setlist #":
                        
                        filteredCards = filteredCards.OrderBy(vm => vm.Card.SetCodes[0]).ToList();
                        break;
                }
                return filteredCards;
            }
        }

        // monsters, spells, traps
        private string _selectedCardCategory = "All";
        public string SelectedCardCategory
        {
            get { return _selectedCardCategory; }
            set => OnCategoryChanged(value);
        }
        public List<string> SelectCardCategory
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

        private string _selectedCardType = string.Empty;
        public string SelectedCardType
        {
            get { return _selectedCardType; }
            set
            {
                SetProperty(ref _selectedCardType, value);
                OnPropertyChanged(nameof(FilteredCards));
            }
        }

        public List<string> SortByDropdownOptions =>
            new List<string>()
            {
                "Alphabetical",
                "Setlist #",
                "ATK",
                "DEF"
            };
        private string _sortBy = "Alphabetical";
        public string SortBy
        {
            get { return _sortBy; }
            set
            {
                _sortBy = value;
                OnPropertyChanged(nameof(FilteredCards));
            }
        }

        public List<string> SelectCardType
        {
            get
            {
                switch (_selectedCardCategory)
                {
                    case "Monsters":
                        return _monsterTypeDropdown;
                    case "Spells":
                        return _spellTypeDropdown;
                    case "Traps":
                        return _trapTypeDropdown;
                    case "Skills":
                        return _skillTypeDropdown;
                    default:
                        return new List<string>();
                }
            }
        }

        private List<string> _monsterTypeDropdown
        {
            get
            {
                var list = new List<string>();
                list.Add("All Monster Types");
                list.AddRange(
                    Enum.GetNames(typeof(MonsterType)).ToList());
                return list;
            }
        }
        private List<string> _spellTypeDropdown
        {
            get
            {
                var list = new List<string>();
                list.Add("All Spell Types");
                list.AddRange(
                    Enum.GetNames(typeof(SpellType)).ToList());
                return list;
            }
        }
        private List<string> _trapTypeDropdown
        {
            get
            {
                var list = new List<string>();
                list.Add("All Trap Types");
                list.AddRange(
                    Enum.GetNames(typeof(TrapType)).ToList());
                return list;
            }
        }

        private List<string> _skillTypeDropdown = new List<string>()
        {
            "All Characters",
            "Joey",
            "Kaiba",
            "Mai",
            "Yami Yugi",
            "Pegasus",
            "Ishizu",
            "Bonz"
        };

        private string _selectedCardAttribute = "All Attributes";
        public string SelectedCardCAttribute
        {
            get { return _selectedCardAttribute; }
            set
            {
                SetProperty(ref _selectedCardAttribute, value);
                OnPropertyChanged(nameof(FilteredCards));
            }
        }
        public List<string> SelectCardAttribute
        {
            get
            {
                var list = new List<string>()
                {
                    "All"
                };
                list.AddRange(Enum.GetNames(typeof(MonsterAttribute)).ToList());
                return list;
            }
        }

        private string _cardSearchFilterName = string.Empty;
        public string CardSearchFilterName
        {
            get { return _cardSearchFilterName; }
            set
            {
                SetProperty(ref _cardSearchFilterName, value);
                OnPropertyChanged(nameof(FilteredCards));
            }
        }

        private string _cardSearchFilterDescription = string.Empty;
        public string CardSearchFilterDescription
        {
            get { return _cardSearchFilterDescription; }
            set
            {
                SetProperty(ref _cardSearchFilterDescription, value);
                OnPropertyChanged(nameof(FilteredCards));
            }
        }

        private List<string> _packList =>
            new List<string>
            {
                "All",
                "Starter Deck Destiny Masters",
                "Starter Deck Duelists of Tomorrow",
                "Yu-Gi-Oh! Day Promo",
                "Booster Pack Arena of Lost Souls",
                "Booster Pack Attack from the Deep",
                "Tournament Pack 1",
            };
        public List<string> PackList => _packList;
        public Dictionary<string, string> PackListWithAbbr
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "All",                               "All"},
                    { "Starter Deck Destiny Masters",      "SS01"},
                    { "Starter Deck Duelists of Tomorrow", "SS02"},
                    { "Yu-Gi-Oh! Day Promo",               "YDPR"},
                    { "Booster Pack Arena of Lost Souls",  "SBLS"},
                    { "Booster Pack Attack from the Deep", "SBAD"},
                    { "Tournament Pack 1",                 "STP1"},
                };
            }
        }

        private string _selectedPack = "All";
        public string SelectedPack
        {
            get { return _selectedPack; }
            set
            {
                SetProperty(ref _selectedPack, value);
                OnPropertyChanged(nameof(FilteredCards));
            }
        }

        public bool DisplayAttributeDropdown { get; set; } = false;

        private void OnCategoryChanged(string category)
        {
            SetProperty(ref _selectedCardCategory, category);
            OnPropertyChanged(nameof(SelectCardType));
            OnPropertyChanged(nameof(FilteredCards));

            switch (category)
            {
                case "Monsters":
                    DisplayAttributeDropdown = true;
                    break;
                case "Spells":
                    DisplayAttributeDropdown = false;
                    break;
                case "Traps":
                    DisplayAttributeDropdown = false;
                    break;
                case "Skills":
                    DisplayAttributeDropdown = false;
                    break;
            }

            OnPropertyChanged(nameof(DisplayAttributeDropdown));
        }
    }
}
