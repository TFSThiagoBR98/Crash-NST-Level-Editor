namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class EAP_Sweeper_BehaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect = new();
    }
}
