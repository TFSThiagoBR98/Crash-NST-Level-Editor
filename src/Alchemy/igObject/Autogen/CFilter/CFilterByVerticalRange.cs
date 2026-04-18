namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class CFilterByVerticalRange : CFilterMethod
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _verticalRangeAbove;
        [FieldAttr(nst: 28, ctr: 20)] public float _verticalRangeBelow;
        [FieldAttr(nst: 32, ctr: 24)] public bool _relativeToCenter = true;
    }
}
