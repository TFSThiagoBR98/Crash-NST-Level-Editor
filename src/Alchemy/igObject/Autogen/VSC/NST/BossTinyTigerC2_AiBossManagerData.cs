namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class BossTinyTigerC2_AiBossManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Query_Filter = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public float _Float_0x34;
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Damage_Data_0x48 = new();
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 92)] public float _Float_0x5c;
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 100)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 104)] public igHandleMetaField _Damage_Data_0x68 = new();
        [FieldAttr(nst: 112)] public float _Float_0x70;
        [FieldAttr(nst: 116)] public float _Float_0x74;
    }
}
