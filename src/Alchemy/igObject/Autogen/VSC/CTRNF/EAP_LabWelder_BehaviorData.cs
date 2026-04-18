namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class EAP_LabWelder_BehaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Bolt_Point = new();
    }
}
