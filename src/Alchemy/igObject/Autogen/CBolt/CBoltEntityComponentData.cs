namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CBoltEntityComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _entityToBoltTo = new();
        [FieldAttr(ctr: 24)] public CBoltPoint? _boltPoint;
        [FieldAttr(ctr: 32)] public bool _positionOffset;
    }
}
