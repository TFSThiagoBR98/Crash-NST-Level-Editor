namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 48, align: 16)]
    public class igVfxOrbitAxisAngleDistanceBaseOperator : igVfxOrbitBaseOperator
    {
        [FieldAttr(nst: 48, ctr: 32)] public igVec3fAlignedMetaField _axis = new();
    }
}
