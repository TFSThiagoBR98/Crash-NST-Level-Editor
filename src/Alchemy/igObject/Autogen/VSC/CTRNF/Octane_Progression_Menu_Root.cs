namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Progression_Menu_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public int _InternalStore__internalCounter;
        [FieldAttr(ctr: 48)] public igObject? _InternalStore__timer = new();
        [FieldAttr(ctr: 56)] public igObject? _InternalStore__gate = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Placeable_0x40 = new();
        [FieldAttr(ctr: 72)] public int _Int;
        [FieldAttr(ctr: 80)] public igHandleMetaField _Gui_Animation_Tag_0x50 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Gui_Animation_Tag_0x58 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Gui_Placeable_0x60 = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Material = new();
    }
}
