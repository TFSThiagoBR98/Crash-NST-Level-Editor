namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class common_RideBoardHazardData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Bool_0x28;
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 56)] public bool _Bool_0x38;
        [FieldAttr(nst: 57)] public bool _Bool_0x39;
        [FieldAttr(nst: 58)] public bool _Bool_0x3a;
        [FieldAttr(nst: 64)] public igHandleMetaField _Spline_Attach_Behavior = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public igHandleMetaField _Spline_Velocity_Mover = new();
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 100)] public float _Float_0x64;
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 108)] public float _Float_0x6c;
    }
}
