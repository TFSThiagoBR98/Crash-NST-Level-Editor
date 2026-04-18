namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Chase_BacktrackTriggerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _HazardDeathState = null;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public string? _String = null;
    }
}
