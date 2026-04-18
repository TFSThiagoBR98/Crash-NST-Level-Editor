namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class WumpaCoinsCounter_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public int _Int;
        [FieldAttr(ctr: 48)] public string? _String = null;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable = new();
    }
}
