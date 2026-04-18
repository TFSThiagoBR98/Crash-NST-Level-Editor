namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class PauseMenu_Root : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _AnimationIdle = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _TitleScreenZoneInfo = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _localCurrZoneInfo = new();
        [FieldAttr(nst: 64)] public igObject? _Internal_GateAction_id_jn9wtv7a_gate = new();
        [FieldAttr(nst: 72)] public int _InternalStore__internalCounter;
        [FieldAttr(nst: 80)] public igHandleMetaField _LevelName = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Gui_Animation_Tag_0x60 = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Gui_Animation_Tag_0x68 = new();
        [FieldAttr(nst: 112)] public float _Float;
    }
}
