namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_NFBoostBar_BoostCount : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 48)] public int _Int;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag = new();
    }
}
