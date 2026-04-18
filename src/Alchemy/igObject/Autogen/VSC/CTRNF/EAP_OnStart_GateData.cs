namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class EAP_OnStart_GateData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 40)] public igVec3fMetaField _Vec_3F = new();
    }
}
