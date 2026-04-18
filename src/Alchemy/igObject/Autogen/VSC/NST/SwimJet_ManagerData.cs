namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class SwimJet_ManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _CrashRidingPlatform = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
    }
}
