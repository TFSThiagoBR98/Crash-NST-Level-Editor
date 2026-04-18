namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Temple_Seesaw_Manager_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _RotatorEntityData = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _PlatformHazardsList = new();
        [FieldAttr(nst: 56)] public float _RotateDuration;
        [FieldAttr(nst: 60)] public float _ResetDuration;
    }
}
