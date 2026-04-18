namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Egypt_SwitchActivatedGateData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 56)] public string? _CrashDeath = null;
        [FieldAttr(nst: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Sound_0x50 = new();
    }
}
