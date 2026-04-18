namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class common_AttachSpawnersToPlayerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_Data_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_Data_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Bolt_Point_0x40 = new();
        [FieldAttr(nst: 72)] public float _Float_0x48;
        [FieldAttr(nst: 76)] public float _Float_0x4c;
        [FieldAttr(nst: 80)] public igHandleMetaField _Int_List = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity_Tag = new();
    }
}
