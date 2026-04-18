namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_EndRaceTimer_HUD_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public int _Int;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Placeable_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Placeable_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Animation_Tag = new();
    }
}
