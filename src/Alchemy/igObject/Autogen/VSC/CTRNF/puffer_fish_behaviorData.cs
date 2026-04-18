namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class puffer_fish_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Sound_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Sound_0x30 = new();
    }
}
