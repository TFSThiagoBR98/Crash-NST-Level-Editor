namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class T113_Mystery_Caves_geyser_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Bolt_Point_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Bolt_Point_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 72)] public bool _Bool;
    }
}
