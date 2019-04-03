using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh
{
    public class YugiohFieldBuff
    {
        public int ATKBuff { get; set; } = 0;
        public int DEFBuff { get; set; } = 0;
    }
    public class YugiohFieldAttributeBuff: YugiohFieldBuff
    {
        public MonsterAttribute AffectedAttribute { get; set; }
    }
    public class YugiohFieldTypeBuff: YugiohFieldBuff
    {
        public MonsterType AffectedType { get; set; }
    }
    public class YugiohNamedBuff: YugiohFieldBuff
    {
        public string NameIncludes { get; set; }
    }
}
