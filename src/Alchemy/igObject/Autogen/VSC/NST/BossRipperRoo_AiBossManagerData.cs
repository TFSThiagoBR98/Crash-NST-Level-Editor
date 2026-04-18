namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class BossRipperRoo_AiBossManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public igHandleMetaField _Waypoint = new();
        [FieldAttr(nst: 72)] public float _Float_0x48;
        [FieldAttr(nst: 80)] public igHandleMetaField _Damage_Data = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(nst: 96)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 100)] public EigEaseMode _Ease_Mode;
        [FieldAttr(nst: 104)] public igHandleMetaField _Vfx_Effect_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Bolt_Point = new();
    }
}
