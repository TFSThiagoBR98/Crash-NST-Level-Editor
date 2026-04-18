namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 4, metaType: typeof(CVscComponentData))]
    public class HavokBehavior_Enemy_Death : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _LaunchDeathOnly;
        [FieldAttr(nst: 48)] public string? _DeathDefault = null;
        [FieldAttr(nst: 56)] public string? _DeathJump = null;
        [FieldAttr(nst: 64)] public string? _DeathSpin = null;
        [FieldAttr(nst: 72)] public Standard_Enemy_Death_c_Standard_Enemy_DeathData.ENewEnum3_id_4cdoc9cv _NewEnum3_id_4cdoc9cv;
        [FieldAttr(nst: 76)] public bool _Bool_0x4c;
        [FieldAttr(nst: 80)] public igHandleMetaField _Havok_Linear_Cast_Query_Parameters = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 96)] public string? _Standard_Enemy_DeathDatas = null;
        [FieldAttr(nst: 104)] public bool _Bool_0x68;
        [FieldAttr(nst: 112)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 136)] public bool _Bool_0x88;
        [FieldAttr(nst: 144)] public igHandleMetaField _Query_Filter_0x90 = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Query_Filter_0x98 = new();
    }
}
