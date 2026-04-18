namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Racer_HUD_HideRaceModeHud : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Animation_Tag_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(ctr: 56)] public EOctaneRaceModes _E_Octane_Race_Modes;
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Animation_Tag_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Placeable_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Gui_Placeable_0x50 = new();
        [FieldAttr(ctr: 88)] public bool _Bool;
        [FieldAttr(ctr: 96)] public igHandleMetaField _Gui_Animation_Tag_0x60 = new();
    }
}
