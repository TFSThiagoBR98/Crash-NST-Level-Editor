namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BlasterTech_CarrotControlData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _CarrotBehaviorStates = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _CarrotRecticleEntityData = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _FindTargetsQuery = new();
    }
}
