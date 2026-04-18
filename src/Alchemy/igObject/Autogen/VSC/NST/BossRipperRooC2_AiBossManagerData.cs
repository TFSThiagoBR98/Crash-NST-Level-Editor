namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class BossRipperRooC2_AiBossManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Waypoint = new();
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public EigEaseType _Ease_Type_0x40;
        [FieldAttr(nst: 68)] public float _Float_0x44;
        [FieldAttr(nst: 72)] public float _Float_0x48;
        [FieldAttr(nst: 76)] public float _Float_0x4c;
        [FieldAttr(nst: 80)] public EigEaseType _Ease_Type_0x50;
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Bolt_Point_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Entity_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Bolt_Point_0x78 = new();
    }
}
