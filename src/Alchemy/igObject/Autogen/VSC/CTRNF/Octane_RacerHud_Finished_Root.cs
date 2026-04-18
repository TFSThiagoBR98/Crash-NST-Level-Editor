namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_RacerHud_Finished_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 48)] public EOctaneRaceModes _E_Octane_Race_Modes;
    }
}
