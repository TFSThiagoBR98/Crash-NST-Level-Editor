namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class ShowPowerUpQuantity : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 48)] public int _Int;
    }
}
