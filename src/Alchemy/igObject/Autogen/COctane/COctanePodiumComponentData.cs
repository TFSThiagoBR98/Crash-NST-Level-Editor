namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class COctanePodiumComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _delayAllStartAnimation;
        [FieldAttr(ctr: 24)] public igHandleMetaField _podiumModel = new();
        [FieldAttr(ctr: 32)] public CBoltPoint? _firstPositionBolt;
        [FieldAttr(ctr: 40)] public CBoltPoint? _secondPositionBolt;
        [FieldAttr(ctr: 48)] public CBoltPoint? _thirdPositionBolt;
        [FieldAttr(ctr: 56)] public CBoltPoint? _cameraBolt;
        [FieldAttr(ctr: 64)] public CPodiumAnimationDataList? _podiumDataList;
    }
}
