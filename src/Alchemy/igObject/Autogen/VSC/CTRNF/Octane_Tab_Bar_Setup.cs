namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Tab_Bar_Setup : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Placeable_0x30 = new();
        [FieldAttr(ctr: 56)] public string? _String_0x38 = null;
        [FieldAttr(ctr: 64)] public string? _String_0x40 = null;
        [FieldAttr(ctr: 72)] public igHandleMetaField _Entity = new();
    }
}
