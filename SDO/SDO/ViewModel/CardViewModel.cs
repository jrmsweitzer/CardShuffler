using SDO.Models.Yugioh;
using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SDO.ViewModel
{
    public class CardViewModel
    {
        public YugiohGameCard Card { get; set; }
        public string Description => Card.Description;
        public string ShortDetailsString
        {
            get
            {
                if (Card is Monster m)
                {
                    var attr = m.Attribute.ToString().ToUpper();
                    var ty = m.Type.ToString();

                    var builder = new StringBuilder();
                    builder.Append($"{attr.ToUpper()} | * Level {m.Level} | [{ty} / ");

                    if (m is NormalMonster)
                        builder.Append("Normal ]");
                    else if (m is EffectMonster effmon)
                    {
                        if (effmon.HasFlipEffect)
                            builder.Append("Flip / ");
                        builder.Append("Effect ]");
                    }
                    else if (m is EffectFusionMonster)
                        builder.Append("Fusion / Effect ]");
                    else if (m is NormalFusionMonster)
                        builder.Append("Fusion / Normal ]");
                    else if (m is RitualMonster)
                        builder.Append("Ritual / Effect ]");

                    builder.Append($" | ATK {m.ATK} | DEF {m.DEF} |");
                    return builder.ToString();
                }
                else if (Card is Spell)
                {
                    if (Card is ContinuousSpell)
                        return "SPELL | Continuous |";
                    else if (Card is EquipSpell)
                        return "SPELL | Equip |";
                    else if (Card is FieldSpell)
                        return "SPELL | Field |";
                    else if (Card is RitualSpell)
                        return "SPELL | Ritual |";
                    else if (Card is QuickplaySpell)
                        return "SPELL | Quickplay |";
                    else
                        return "SPELL";
                }
                else if (Card is Trap)
                {
                    if (Card is ContinuousTrap)
                        return "TRAP | Continuous |";
                    else if (Card is CounterTrap)
                        return "TRAP | Counter |";
                    else
                        return "TRAP";
                }
                else if (Card is Skill s)
                {
                    return $"SKILL | {s.Character} |";
                }
                else
                    return string.Empty;
            }
        }
        public Color BackgroundColor
        {
            get
            {
                if (Card is FusionMonster)
                    return Color.FromRgb(108, 37, 137);
                else if (Card is RitualMonster)
                    return Color.FromRgb(30, 111, 166);
                else if (Card is EffectMonster)
                    return Color.FromRgb(156, 80, 68);
                else if (Card is NormalMonster)
                    return Color.FromRgb(179, 142, 79);
                else if (Card is Trap)
                    return Color.FromRgb(142, 12, 113);
                else if (Card is Spell)
                    return Color.FromRgb(0, 130, 129);
                else if (Card is Skill)
                    return Color.FromRgb(2, 135, 182);
                else
                    return Color.FromRgb(0, 0, 0);
            }
        }

        public string DefaultImage
        {
            get
            {
                var file = $"{Card.SetCodes[0].Replace("-", "").ToLower()}.png";
                return file;
            }
        }
    }
}
