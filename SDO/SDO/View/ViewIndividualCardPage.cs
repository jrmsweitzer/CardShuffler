using SDO.Models.Yugioh;
using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SDO.View
{
    public class ViewIndividualCardPage : ContentPage
    {
        public ViewIndividualCardPage()
        {
        }
        public ViewIndividualCardPage(YugiohGameCard card)
        {
            if (card is Skill skill)
                Content = GetContentForSkillCard(skill);
            else if (card is Spell spell)
                Content = GetContentForSpellCard(spell);
            else if (card is Trap trap)
                Content = GetContentForTrapCard(trap);
            else if (card is Monster monster)
                Content = GetContentForMonsterCard(monster);
        }

        //private ScrollView DisplayCardImages(YugiohGameCard card)
        //{
        //    var layout = new StackLayout();
        //    foreach (var image in card.Images)
        //    {
        //        layout.Children.Add(new Image
        //        {
        //            Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(image))),
        //            HeightRequest = 600
        //        });
        //    }

        //    var scrollView = new ScrollView()
        //    {
        //        VerticalOptions = LayoutOptions.CenterAndExpand,
        //        Content = layout
        //    };

        //    return scrollView;
        //}

        private ScrollView GetContentForSkillCard(Skill card)
        {
            var layout = new StackLayout
            {
                Children = {
                    new Label { Text = $"Skill - {card.Character}" },
                    new Label { Text = $"{card.Name}" },
                    new Label { Text = string.Empty },
                    new Label { Text = "Skill Activation:" },
                    new Label { Text = $"{card.SkillActivationDescription}", Margin = new Thickness(10, 0, 0, 0) },
                    new Label { Text = "Effect:" },
                    new Label { Text = $"{card.Description}", Margin = new Thickness(10, 0, 0, 0) },
                    new Label { Text = string.Empty },
                    new Label { Text = $"{string.Join(", ", card.SetCodes)}" }
                },
                HeightRequest = 1500
            };

            var scrollView = new ScrollView()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Content = layout
            };

            return scrollView;
        }

        private ScrollView GetContentForSpellCard(Spell card)
        {
            //string cardType;
            //if (card is ContinuousSpell) cardType = "Continuous Spell";
            //else if (card is EquipSpell) cardType = "Equip Spell";
            //else if (card is RitualSpell) cardType = "Ritual Spell";
            //else if (card is FieldSpell) cardType = "Field Spell";
            //else if (card is QuickplaySpell) cardType = "Quickplay Spell";
            //else cardType = "Spell";

            var layout = new StackLayout
            {
                //Children = {
                //    new Label { Text = $"{cardType}" },
                //    new Label { Text = $"{card.Name}" },
                //    new Label { Text = string.Empty },
                //    new Label { Text = $"{card.Description}", Margin = new Thickness(10, 0, 0, 0) },
                //    new Label { Text = string.Empty },
                //    new Label { Text = card.CardCode.ToString() },
                //    new Label { Text = $"{string.Join(", ", card.SetCodes)}" },
                //}
            };

            foreach (var setcode in card.SetCodes)
            {
                var image = new Image
                {
                    Source = $"{setcode.Replace("-", "").ToLower()}.png"
                };
                layout.Children.Add(image);
            }

            var scrollView = new ScrollView()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Content = layout
            };

            return scrollView;
        }

        private StackLayout GetContentForTrapCard(Trap card)
        {
            string cardType;
            if (card is ContinuousTrap) cardType = "Continuous Trap";
            else if (card is CounterTrap) cardType = "Counter Trap";
            else cardType = "Trap";

            return new StackLayout
            {
                Children = {
                    new Label { Text = $"{cardType}" },
                    new Label { Text = $"{card.Name}" },
                    new Label { Text = string.Empty },
                    new Label { Text = $"{card.Description}", Margin = new Thickness(10, 0, 0, 0) },
                    new Label { Text = string.Empty },
                    new Label { Text = card.CardCode.ToString() },
                    new Label { Text = $"{string.Join(", ", card.SetCodes)}" },
                }
            };
        }

        private StackLayout GetContentForMonsterCard(Monster card)
        {
            var levelString = new StringBuilder();
            for (int i = 0; i < card.Level; i++)
                levelString.Append("*");

            var typeString = new StringBuilder($"[{card.Type.ToString()}");
            if (card is RitualMonster) typeString.Append("/Ritual");
            if (card is FusionMonster) typeString.Append("/Fusion");
            if (card is EffectMonster || card is EffectFusionMonster) typeString.Append("/Effect");
            if (card is NormalMonster) typeString.Append("/Normal");
            typeString.Append("]");

            var layout = new StackLayout
            {
                Children = {
                    new Label { Text = card.Name },
                    new Label { Text = card.Attribute.ToString().ToUpper() },
                    new Label { Text = levelString.ToString() },
                    new Label { Text = typeString.ToString() },
                }
            };

            if (card is FusionMonster fusionMonster)
            {
                var fusionString = string.Join(" + ", fusionMonster.FusionMaterials.Select(material => $"\"{material}\""));
                layout.Children.Add(new Label { Text = fusionString });
            }

            layout.Children.Add(new Label { Text = $"{card.Description}", Margin = new Thickness(10, 0, 0, 0) });
            layout.Children.Add(new Label { Text = $"ATK/{card.ATK.ToString()} DEF/{card.DEF.ToString()}" });

            layout.Children.Add(new Label { Text = string.Empty });

            if (card.CardCode != 0)
                layout.Children.Add(new Label { Text = card.CardCode.ToString() });

            layout.Children.Add(new Label { Text = $"{string.Join(", ", card.SetCodes)}" });
            return layout;
        }
    }
}