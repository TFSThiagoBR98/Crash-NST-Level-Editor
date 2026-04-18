namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class PowerUpBorder : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Animation_Tag_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable = new();
    }
}
