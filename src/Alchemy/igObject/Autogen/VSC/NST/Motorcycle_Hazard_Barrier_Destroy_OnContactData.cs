namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Motorcycle_Hazard_Barrier_Destroy_OnContactData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 48)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 72)] public bool _Bool_0x48;
        [FieldAttr(nst: 76)] public float _Float_0x4c;
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 92)] public bool _Bool_0x5c;
        [FieldAttr(nst: 96)] public float _Float_0x60;
    }
}
