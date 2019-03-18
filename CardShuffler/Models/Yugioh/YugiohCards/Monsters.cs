using CardShuffler.Models.Yugioh.YugiohCards.Monsters;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class MonsterList
    {
        public static List<YugiohGameCard> GetMonsters(YugiohGame game)
        {
            return new List<YugiohGameCard>()
            {
                // A
                new NormalMonster(game)
                {
                    Name = "Alligator's Sword",
                    ATK = 1500,
                    DEF = 1200,
                    Level = 4,
                    Type = MonsterType.Beast,
                    Attribute = MonsterAttribute.Earth,
                },
                new EffectFusionMonster(game)
                {
                    Name = "Alligator's Sword Dragon",
                    ATK = 1700,
                    DEF = 1500,
                    Level = 5,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Wind,
                    Effects = new List<Effect>(),
                },
                new EffectMonster(game)
                {
                    Name = "Amazoness Chain Master",
                    ATK = 1500,
                    DEF = 1300,
                    Level = 4,
                    Type = MonsterType.Warrior,
                    Attribute = MonsterAttribute.Earth,
                },
                new EffectMonster(game)
                {
                    Name = "Amazoness Sage",
                    ATK = 1400,
                    DEF = 700,
                    Level = 4,
                    Type = MonsterType.Warrior,
                    Attribute = MonsterAttribute.Earth,
                },
                new EffectMonster(game)
                {
                    Name = "Amazoness Swords Woman",
                    ATK = 1500,
                    DEF = 1600,
                    Level = 4,
                    Type = MonsterType.Warrior,
                    Attribute = MonsterAttribute.Earth,
                },
                // B
                new NormalMonster(game)
                {
                    Name = "Baby Dragon",
                    ATK = 1200,
                    DEF = 700,
                    Level = 3,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Wind,
                },
                new NormalMonster(game)
                {
                    Name = "Battle Ox",
                    ATK = 1700,
                    DEF = 1000,
                    Level = 4,
                    Type = MonsterType.BeastWarrior,
                    Attribute = MonsterAttribute.Earth
                },
                new EffectMonster(game)
                {
                    Name = "Birdface",
                    ATK = 1600,
                    DEF = 1600,
                    Level = 4,
                    Type = MonsterType.WingedBeast,
                    Attribute = MonsterAttribute.Wind,
                },
                new NormalMonster(game)
                {
                    Name = "Blue-Eyes White Dragon",
                    ATK = 3000,
                    DEF = 2500,
                    Level = 8,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Light
                },
                // C
                new EffectMonster(game)
                {
                    Name = "Copycat",
                    ATK = 0,
                    DEF = 0,
                    Level = 1,
                    Type = MonsterType.Spellcaster,
                    Attribute = MonsterAttribute.Light,
                },
                // D
                // E
                // F
                new NormalMonster(game)
                {
                    Name = "Flame Manipulator",
                    ATK = 900,
                    DEF = 1000,
                    Level = 3,
                    Type = MonsterType.Spellcaster,
                    Attribute = MonsterAttribute.Fire,
                },
                new NormalFusionMonster(game)
                {
                    Name = "Flame Swordsman",
                    ATK = 1800,
                    DEF = 1600,
                    Level = 5,
                    Type = MonsterType.Warrior,
                    Attribute = MonsterAttribute.Fire,
                    FusionMaterials = new List<string>()
                    {
                        "Flame Manipulator",
                        "Masaki the Legendary Swordsman"
                    }
                },
                // G
                new EffectMonster(game)
                {
                    Name = "Gearfried the Iron Knight",
                    ATK = 1800,
                    DEF = 1600,
                    Level = 4,
                    Type = MonsterType.Warrior,
                    Attribute = MonsterAttribute.Earth,
                },
                // H
                new HarpieLady1(game),
                new EffectMonster(game)
                {
                    Name = "Harpie Lady 2",
                    ATK = 1300,
                    DEF = 1400,
                    Level = 4,
                    Type = MonsterType.WingedBeast,
                    Attribute = MonsterAttribute.Wind,
                },
                new EffectMonster(game)
                {
                    Name = "Harpie Lady 3",
                    ATK = 1300,
                    DEF = 1400,
                    Level = 4,
                    Type = MonsterType.WingedBeast,
                    Attribute = MonsterAttribute.Wind,
                },
                new EffectMonster(game)
                {
                    Name = "Harpie Lady Sisters",
                    ATK = 1950,
                    DEF = 2100,
                    Level = 6,
                    Type = MonsterType.WingedBeast,
                    Attribute = MonsterAttribute.Wind,
                    CanBeNormalSummoned = false,
                    MustFirstBeSpecialSummoned = true,
                },
                // I
                // J
                // K
                new EffectMonster(game)
                {
                    Name = "Kaibaman",
                    ATK = 200,
                    DEF = 700,
                    Level = 3,
                    Type = MonsterType.Warrior,
                    Attribute = MonsterAttribute.Light
                },
                // L
                new EffectMonster(game)
                {
                    Name = "Little Winguard",
                    ATK = 1400,
                    DEF = 1800,
                    Level = 4,
                    Type = MonsterType.Warrior,
                    Attribute = MonsterAttribute.Wind,
                },
                new NormalMonster(game)
                {
                    Name = "Luster Dragon #2",
                    ATK = 2400,
                    DEF = 1400,
                    Level = 6,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Wind
                },
                new EffectMonster(game)
                {
                    Name = "Lord of D.",
                    ATK = 1200,
                    DEF = 1100,
                    Level = 4,
                    Type = MonsterType.Spellcaster,
                    Attribute = MonsterAttribute.Dark
                },
                // M
                new NormalMonster(game)
                {
                    Name = "Masaki the Legendary Swordsman",
                    ATK = 1100,
                    DEF = 1100,
                    Level = 4,
                    Type = MonsterType.Warrior,
                    Attribute = MonsterAttribute.Earth,
                },
                new NormalMonster(game)
                {
                    Name = "Meteor Dragon",
                    ATK = 1800,
                    DEF = 2000,
                    Level = 6,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Earth,
                },
                // N
                // O
                // P
                // Q
                // R
                new NormalMonster(game)
                {
                    Name = "Red-Eyes B. Dragon",
                    ATK = 2400,
                    DEF = 2000,
                    Level = 7,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Dark
                },
                new NormalMonster(game)
                {
                    Name = "Ryu-Kishin Powered",
                    ATK = 1600,
                    DEF = 1200,
                    Level = 4,
                    Type = MonsterType.Fiend,
                    Attribute = MonsterAttribute.Dark
                },
                // S
                new EffectMonster(game)
                {
                    Name = "Sonic Shooter",
                    ATK = 1300,
                    DEF = 600,
                    Level = 4,
                    Type = MonsterType.WingedBeast,
                    Attribute = MonsterAttribute.Wind,
                },
                new EffectMonster(game)
                {
                    Name = "Spirit Ryu",
                    ATK = 1000,
                    DEF = 1000,
                    Level = 4,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Wind
                },
                // T
                new NormalFusionMonster(game)
                {
                    Name = "Thousand Dragon",
                    ATK = 2400,
                    DEF = 2000,
                    Level = 7,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Wind,
                    FusionMaterials = new List<string>()
                    {
                        "Time Wizard",
                        "Baby Dragon"
                    }
                },
                new EffectMonster(game)
                {
                    Name = "Time Wizard",
                    ATK = 500,
                    DEF = 400,
                    Level = 2,
                    Type = MonsterType.Spellcaster,
                    Attribute = MonsterAttribute.Light,
                },
                new NormalMonster(game)
                {
                    Name = "Toon Alligator",
                    ATK = 200,
                    DEF = 200,
                    Level = 2,
                    Type = MonsterType.Aqua,
                    Attribute = MonsterAttribute.Dark,
                },
                new NormalMonster(game)
                {
                    Name = "Toon Masked Sorcerer",
                    ATK = 200,
                    DEF = 200,
                    Level = 2,
                    Type = MonsterType.Aqua,
                    Attribute = MonsterAttribute.Dark,
                },
                new NormalMonster(game)
                {
                    Name = "Toon Mermaid",
                    ATK = 200,
                    DEF = 200,
                    Level = 2,
                    Type = MonsterType.Aqua,
                    Attribute = MonsterAttribute.Dark,
                },
                new NormalMonster(game)
                {
                    Name = "Toon Summoned Skull",
                    ATK = 200,
                    DEF = 200,
                    Level = 2,
                    Type = MonsterType.Aqua,
                    Attribute = MonsterAttribute.Dark,
                },
                new EffectMonster(game)
                {
                    Name = "Twin-Headed Behemoth",
                    ATK = 1500,
                    DEF = 1200,
                    Level = 3,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Wind
                },
                new EffectMonster(game)
                {
                    Name = "Tyrant Dragon",
                    ATK = 2900,
                    DEF = 2500,
                    Level = 8,
                    Type = MonsterType.Dragon,
                    Attribute = MonsterAttribute.Fire
                },
                // U
                // V
                // W
                // X
                // Y
                // Z
            };
        }
    }
}
