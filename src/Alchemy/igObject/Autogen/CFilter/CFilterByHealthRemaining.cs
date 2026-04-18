namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CFilterByHealthRemaining : CFilterMethod
    {
        public enum EComparisonType
        {
            eCT_LessThanEqual = 0,
            eCT_GreaterThanEqual = 1,
        }

        [FieldAttr(nst: 24, ctr: 16)] public EComparisonType _comparisonType;
        [FieldAttr(nst: 28, ctr: 20)] public int _healthPercentageThreshold = 50;
    }
}
