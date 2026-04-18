namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_RelicRace_TimeCounter : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 48)] public float _Float;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 64)] public string? _String = null;
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 80)] public int _Int;
    }
}
