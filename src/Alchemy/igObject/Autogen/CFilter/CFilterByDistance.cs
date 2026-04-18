namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CFilterByDistance : CFilterMethod
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _rangeRestriction;
        [FieldAttr(nst: 28, ctr: 20)] public bool _useExtents;
    }
}
