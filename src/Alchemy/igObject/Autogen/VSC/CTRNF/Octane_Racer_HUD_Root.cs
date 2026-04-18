namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Racer_HUD_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable_0x28 = new();
        [FieldAttr(ctr: 48)] public EOctaneRaceModes _E_Octane_Race_Modes_0x30;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable_0x38 = new();
        [FieldAttr(ctr: 64)] public EOctaneRaceModes _E_Octane_Race_Modes_0x40;
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Animation_Tag = new();
    }
}
