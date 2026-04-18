namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 32, align: 16)]
    public class igVfxTranslatePivotOperator : igVfxOperator
    {
        [FieldAttr(nst: 32, ctr: 16)] public igVec3fAlignedMetaField _offset = new();
    }
}
