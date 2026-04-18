namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_Crash_Hud_Objective_Counter : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Gui_Animation_Tag_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(nst: 56)] public float _Float;
        [FieldAttr(nst: 60)] public int _Int;
        [FieldAttr(nst: 64)] public igHandleMetaField _Vfx_Spawned_Effect = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Gui_Animation_Tag_0x48 = new();
    }
}
