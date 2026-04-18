namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CRotatingMaskComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _timeToFadeOut;
        [FieldAttr(ctr: 20)] public igVec3fMetaField _offset = new();
        [FieldAttr(ctr: 32)] public CBoltPoint? _boltPoint;
    }
}
