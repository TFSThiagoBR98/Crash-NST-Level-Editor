namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class B301_TinyTiger_BossEncounterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Waypoint_0x38 = new();
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_0x48 = new();
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Waypoint_0x60 = new();
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 112)] public igHandleMetaField _Game_Bool_Variable = new();
    }
}
