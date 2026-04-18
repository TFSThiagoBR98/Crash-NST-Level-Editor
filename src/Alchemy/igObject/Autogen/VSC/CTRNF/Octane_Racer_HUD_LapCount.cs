namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Racer_HUD_LapCount : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public string? _String_0x28 = null;
        [FieldAttr(ctr: 48)] public string? _String_0x30 = null;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Placeable_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 80)] public int _Int_0x50;
        [FieldAttr(ctr: 84)] public int _Int_0x54;
    }
}
