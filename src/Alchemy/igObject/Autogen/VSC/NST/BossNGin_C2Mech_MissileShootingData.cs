namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNGin_C2Mech_MissileShootingData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_Data = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Vector3_List_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Vector3_List_0x40 = new();
        [FieldAttr(nst: 72)] public float _Float_0x48;
        [FieldAttr(nst: 76)] public float _Float_0x4c;
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public float _Float_0x58;
    }
}
