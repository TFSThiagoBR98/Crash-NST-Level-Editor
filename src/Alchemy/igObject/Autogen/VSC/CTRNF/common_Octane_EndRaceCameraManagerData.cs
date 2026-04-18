namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Octane_EndRaceCameraManagerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Camera = new();
        [FieldAttr(ctr: 40)] public float _Float_0x28;
        [FieldAttr(ctr: 44)] public bool _Bool_0x2c;
        [FieldAttr(ctr: 48)] public float _Float_0x30;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(ctr: 64)] public EigEaseType _Ease_Type_0x40;
        [FieldAttr(ctr: 68)] public bool _Bool_0x44;
        [FieldAttr(ctr: 72)] public igHandleMetaField _Camera_List = new();
        [FieldAttr(ctr: 80)] public int _Int_0x50;
        [FieldAttr(ctr: 84)] public bool _Bool_0x54;
        [FieldAttr(ctr: 88)] public float _Float_0x58;
        [FieldAttr(ctr: 92)] public int _Int_0x5c;
        [FieldAttr(ctr: 96)] public float _Float_0x60;
        [FieldAttr(ctr: 100)] public EigEaseType _Ease_Type_0x64;
        [FieldAttr(ctr: 104)] public bool _Bool_0x68;
        [FieldAttr(ctr: 108)] public float _Float_0x6c;
        [FieldAttr(ctr: 112)] public bool _Bool_0x70;
    }
}
