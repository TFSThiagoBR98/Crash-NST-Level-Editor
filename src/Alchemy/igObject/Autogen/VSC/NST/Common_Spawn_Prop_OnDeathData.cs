namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Common_Spawn_Prop_OnDeathData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public string? _String = null;
    }
}
