namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Medieval_Enemy_HavokBehavior_TwoHead_LabAssistant_PushPlayerManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public float _Float_0x34;
        [FieldAttr(nst: 56)] public igHandleMetaField _Waypoint_List = new();
        [FieldAttr(nst: 64)] public igVec3fMetaField _Vec_3F = new();
    }
}
