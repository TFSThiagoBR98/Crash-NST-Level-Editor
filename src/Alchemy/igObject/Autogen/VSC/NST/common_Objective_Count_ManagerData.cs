namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Objective_Count_ManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String = null;
        [FieldAttr(nst: 48)] public float _Float;
        [FieldAttr(nst: 52)] public bool _Bool;
        [FieldAttr(nst: 56)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Game_Int_Variable_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Game_Int_Variable_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _PlayerDied = new();
    }
}
