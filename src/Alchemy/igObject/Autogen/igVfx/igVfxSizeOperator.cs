namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 32, align: 8)]
    public class igVfxSizeOperator : igVfxSizeBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVec3fMetaField _size = new();
    }
}
