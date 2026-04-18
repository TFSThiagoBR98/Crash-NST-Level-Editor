namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class AirJet_VFX_ModCustomizationData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _VFX_Pure_Bone_R_Wing = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _VFX_Pure_Bone_L_Wing = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _VFX_Pure_Bone_SecondaryMod = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _EBOLT_ORIGIN = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Pri_Detach = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _VFX_Sec_Attach = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _VFX_Sec_Detatch = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Pri_Attach = new();
    }
}
