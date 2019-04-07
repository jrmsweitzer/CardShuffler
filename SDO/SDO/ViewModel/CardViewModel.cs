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
        public string ShortDetailsString
        {
            get
            {
                if (Card is Monster m)
                {
                    var attr = m.Attribute.ToString().ToUpper();
                    var ty = m.Type.ToString();
                    return $"{attr} {ty} {m.Level} - {m.ATK}/{m.DEF}";
                }
                else if (Card is Spell)
                {
                    if (Card is ContinuousSpell)
                        return "Continuous Spell";
                    else if (Card is EquipSpell)
                        return "Equip Spell";
                    else if (Card is FieldSpell)
                        return "Field Spell";
                    else if (Card is RitualSpell)
                        return "Ritual Spell";
                    else if (Card is QuickplaySpell)
                        return "Quickplay Spell";
                    else
                        return "Normal Spell";
                }
                else if (Card is Trap)
                {
                    if (Card is ContinuousTrap)
                        return "Continuous Trap";
                    else if (Card is CounterTrap)
                        return "Counter Trap";
                    else
                        return "Normal Trap";
                }
                else if (Card is Skill s)
                {
                    return $"{s.Character} Skill";
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
    }
}
