namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 8)]
    public class CUpsampleMaterial : igFxMaterial
    {
        [FieldAttr(nst: 120)] public bool _largeRadius;
        [FieldAttr(nst: 121)] public bool _fastFilter;
    }
}
