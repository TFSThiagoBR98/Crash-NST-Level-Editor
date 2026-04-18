namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_InGame_Open_Menu : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Animation_Tag_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Animation_Tag_0x48 = new();
        [FieldAttr(ctr: 80)] public float _Float;
        [FieldAttr(ctr: 88)] public igHandleMetaField _Gui_Placeable_0x58 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Gui_Animation_Tag_0x60 = new();
        [FieldAttr(ctr: 104)] public igObject? _InternalStore_updateNodeUpdater = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Gui_Placeable_0x70 = new();
        [FieldAttr(ctr: 120)] public EPlayerId _E_Player_Id;
    }
}
