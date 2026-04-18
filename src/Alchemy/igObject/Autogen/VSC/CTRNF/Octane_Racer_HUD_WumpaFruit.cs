namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Racer_HUD_WumpaFruit : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 72)] public igObject? _InternalStore__gate = new();
        [FieldAttr(ctr: 80)] public int _Int_0x50;
        [FieldAttr(ctr: 84)] public int _Int_0x54;
        [FieldAttr(ctr: 88)] public bool _Bool;
        [FieldAttr(ctr: 96)] public string? _String = null;
        [FieldAttr(ctr: 104)] public igHandleMetaField _Sound_0x68 = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Sound_0x70 = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _Sound_0x78 = new();
    }
}
