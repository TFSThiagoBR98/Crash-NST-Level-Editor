namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Lobby_PitStop : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 48)] public string? _String_0x30 = null;
        [FieldAttr(ctr: 56)] public igHandleMetaField _InternalStore_project = new();
        [FieldAttr(ctr: 64)] public string? _String_0x40 = null;
        [FieldAttr(ctr: 72)] public string? _String_0x48 = null;
    }
}
