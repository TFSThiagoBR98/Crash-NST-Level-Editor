namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class T113_Mystery_Caves_trex_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 40)] public float _Float;
        [FieldAttr(ctr: 48)] public string? _String = null;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound = new();
    }
}
