namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CPencilShape : CShape
    {
        [FieldAttr(nst: 16)] public float _radius = 60.0f;
        [FieldAttr(nst: 20)] public float _totalHeight = 100.0f;
        [FieldAttr(nst: 24)] public float _heightOfEnds = 25.0f;
    }
}
