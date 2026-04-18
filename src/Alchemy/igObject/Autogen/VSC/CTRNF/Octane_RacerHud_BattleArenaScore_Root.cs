namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_RacerHud_BattleArenaScore_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 48)] public EOctaneRaceModes _E_Octane_Race_Modes;
        [FieldAttr(ctr: 52)] public bool _Bool_0x34;
        [FieldAttr(ctr: 53)] public bool _Bool_0x35;
    }
}
