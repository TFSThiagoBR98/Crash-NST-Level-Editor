namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Racer_HUD_WrongWay : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public bool _Bool;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(ctr: 72)] public igObject? _InternalStore__timer = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Gui_Animation_Tag_0x50 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Gui_Animation_Tag_0x58 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Entity_0x60 = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Entity_0x68 = new();
        [FieldAttr(ctr: 112)] public EDriverFaction _E_Driver_Faction;
        [FieldAttr(ctr: 120)] public igHandleMetaField _Sound_0x78 = new();
    }
}
