namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class BossPinstripe_AiBossManager_cData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public float _Float_0x34;
        [FieldAttr(nst: 56)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity = new();
    }
}
