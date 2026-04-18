namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class GameObject_Hazard_SwitchData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Bool_0x28;
        [FieldAttr(nst: 41)] public bool _Bool_0x29;
        [FieldAttr(nst: 48)] public string? _String = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 72)] public bool _Bool_0x48;
        [FieldAttr(nst: 76)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 108)] public bool _Bool_0x6c;
        [FieldAttr(nst: 112)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Fx_Material_Redirect_Table = new();
    }
}
