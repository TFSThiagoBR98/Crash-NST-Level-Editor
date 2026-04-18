namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_Crash_Boss_Spot_Hud_Root : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(nst: 64)] public string? _String = null;
    }
}
