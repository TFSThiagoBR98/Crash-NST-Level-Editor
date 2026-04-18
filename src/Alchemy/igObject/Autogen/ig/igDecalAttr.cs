namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class igDecalAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 20)] public float _decalOffset;
        [FieldAttr(nst: 28, ctr: 24)] public float _decalSlope;
    }
}
