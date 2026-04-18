namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 16)]
    public class igVfxTranslateOperator : igVfxFrameOperator
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fAlignedMetaField _offset = new();
    }
}
