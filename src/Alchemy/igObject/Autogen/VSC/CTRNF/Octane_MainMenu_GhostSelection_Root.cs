namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_MainMenu_GhostSelection_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 48)] public int _InternalStore__internalCounter;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable_0x38 = new();
        [FieldAttr(ctr: 64)] public igObject? _InternalStore_updateNodeUpdater = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Placeable_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Gui_Animation_Tag_0x50 = new();
        [FieldAttr(ctr: 88)] public float _Float;
        [FieldAttr(ctr: 92)] public EOctaneRaceModes _E_Octane_Race_Modes;
        [FieldAttr(ctr: 96)] public igHandleMetaField _Localized_String = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Gui_Animation_Tag_0x68 = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Gui_Animation_Tag_0x70 = new();
    }
}
